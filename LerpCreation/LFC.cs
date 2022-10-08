using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LerpCreation
{
  public enum Type
  {
    LessThan = 0,
    GreaterThan = 1,
    LessThanOrEqual = 2,
    GreaterThanOrEqual = 3
  }

  public enum Operation
  {
    Addition = 0,
    Subtraction = 1,
    Multiplication = 2,
    Division = 3,
    Pow = 4,
    SquareRt = 5
  }

  public struct LerpStep
  {
    public int id;
    public Type type;
    public Operation operation;
    // the number that is used for type's check
    public double x;
    // the number that is used for the operation
    public double y;
    public bool useT;
  }

  public partial class LFC : Form
  {
    private bool dark = false;
    private int id = 0;

    private LerpStep currentStep;
    
    public List<LerpStep> steps = new List<LerpStep>();

    public LFC()
    {
      InitializeComponent();
      
      currentStep = new LerpStep();
      currentStep.id = -1;
      
      ReshapeGraph();
    }

    double DoOperation(Operation o, double x, double i)
    {
      switch (o)
      {
        case Operation.Addition:
          return x + i;
        case Operation.Subtraction:
          return x - i;
        case Operation.Multiplication:
          return x * i;
        case Operation.Division:
          return x / i;
        case Operation.Pow:
          return Math.Pow(x,i);
        case Operation.SquareRt:
          return Math.Sqrt(x);
      }

      return x;
    }
    void ReshapeGraph()
    {
      chart1.Series[0].Points.Clear();
      string cpp = "// Includes\n#include <cmath>\n\ndouble LerpFunc(t) {\n  double val = t;\n";
      string lua = "-- Requires math functions to be exposed!\n\nfunction LerpFunc(t)\n  local val = t\n";
      if (steps.Count != 0)
      {
        for (double i = 0; i <= 1.1; i += 0.05)
        {
          double y = i;
          foreach (LerpStep s in steps)
          {
            double use = s.y;
            if (s.useT)
              use = i;
            switch (s.type)
            {
              case Type.LessThan:
                if (i < s.x)
                  y = DoOperation(s.operation, y, use);
                break;
              case Type.GreaterThan:
                if (i > s.x)
                  y = DoOperation(s.operation, y, use);
                break;
              case Type.LessThanOrEqual:
                if (i <= s.x)
                  y = DoOperation(s.operation, y, use);
                break;
              case Type.GreaterThanOrEqual:
                if (i >= s.x)
                  y = DoOperation(s.operation, y, use);
                break;
            }
          }
          chart1.Series[0].Points.AddXY(i, y);
        }

        foreach (LerpStep s in steps)
        {
          string use = s.y.ToString(CultureInfo.CurrentCulture);
          if (s.useT)
            use = "val";
          switch (s.type)
          {
            case Type.LessThan:
              cpp += "  if (x < " + s.x + ")\n    val ";
              lua += "  if x < " + s.x + " then\n    val ";
              break;
            case Type.GreaterThan:
              cpp += "  if (x > " + s.x + ")\n    val ";
              lua += "  if x > " + s.x + " then\n    val ";
              break;
            case Type.LessThanOrEqual:
              cpp += "  if (x <= " + s.x + ")\n   val ";
              lua += "  if x <= " + s.x + " then\n    val ";
              break;
            case Type.GreaterThanOrEqual:
              cpp += "  if (x >= " + s.x + ")\n   val ";
              lua += "  if x >= " + s.x + " then\n    val ";
              break;
          }

          switch (s.operation)
          {
            case Operation.Addition:
              cpp += "+= " + use + ";\n";
              lua += "= val + " + use + "\n  end\n";
              break;
            case Operation.Subtraction:
              cpp += "-= " + use + ";\n";
              lua += "= val - " + use + "\n  end\n";
              break;
            case Operation.Multiplication:
              cpp += "*= " + use + ";\n";
              lua += "= val *" + use + "\n  end\n";
              break;
            case Operation.Division:
              cpp += "/= " + use + ";\n";
              lua += "= val / " + use + "\n  end\n";
              break;
            case Operation.Pow:
              cpp += "= val^" + use + ";\n";
              lua += "= val^" + use + "\n  end\n";
              break;
            case Operation.SquareRt:
              cpp += "= sqrt(val);\n";
              lua += "= math.sqrt(val)\n  end\n";
              break;
          }
        }
      }
      else
      {
        chart1.Series[0].Points.AddXY(0, 0);
        chart1.Series[0].Points.AddXY(1, 1);
      }

      cpp += "  return val;\n}";
      lua += "  return val\nend";
      richTextBox1.Text = cpp;
      richTextBox2.Text = lua;
    }

    void fSaveStep(LerpStep st, bool delete = false)
    {
      foreach (LerpStep s in steps)
        if (s.id == st.id)
        {
          steps.Remove(s);
          break;
        }
      
      if (!delete)
        steps.Add(st);

      steps.Sort((x, y) => x.x.CompareTo(y.x));

      listBox1.Items.Clear();
      
      foreach (LerpStep step in steps)
      {
        string ifch = step.type.ToString();
        string op = step.operation.ToString();

        listBox1.Items.Add(ifch + "|" + op + "| t: " + step.x);
      }
      
      ReshapeGraph();
    }
    
    private void createStep_Click(object sender, EventArgs e)
    {
      LerpStep st = new LerpStep();
      st.operation = Operation.Addition;
      st.type = Type.LessThan;
      st.x = 0;
      st.y = 0;
      st.id = id;
      st.useT = false;
      id++;

      currentStep = st;

      fSaveStep(st);

    }

    private void xVal_TextChanged(object sender, EventArgs e)
    {
      TextBox b = (TextBox) sender;
      b.Text = Regex.Replace(b.Text, "[^0-9.]", "");
    }

    private void operationVal_TextChanged(object sender, EventArgs e)
    {
      TextBox b = (TextBox) sender;
      if (b.Text != "t")
        b.Text = Regex.Replace(b.Text, "[^0-9.]", "");
    }

    private void deleteStep_Click(object sender, EventArgs e)
    {
      fSaveStep(currentStep, true);
      currentStep = new LerpStep();
      currentStep.id = -1;
    }

    private void dupStep_Click(object sender, EventArgs e)
    {
      LerpStep s = currentStep;
      s.id = id;
      id++;
      fSaveStep(s);
      currentStep = s;
    }

    private void saveStep_Click(object sender, EventArgs e)
    {
      if (currentStep.id == -1)
        return;

      switch (ifCheck.Text)
      {
        case "LessThan":
          currentStep.type = Type.LessThan;
          break;
        case "GreaterThan":
          currentStep.type = Type.GreaterThan;
          break;
        case "LessThanOrEqual":
          currentStep.type = Type.LessThanOrEqual;
          break;
        case "GreaterThanOrEqual":
          currentStep.type = Type.GreaterThanOrEqual;
          break;
        default:
          currentStep.type = Type.LessThan;
          break;
      }
      switch (operation.Text)
      {
        case "Addition":
          currentStep.operation = Operation.Addition;
          break;
        case "Subtraction":
          currentStep.operation = Operation.Subtraction;
          break;
        case "Multiplication":
          currentStep.operation = Operation.Multiplication;
          break;
        case "Division":
          currentStep.operation = Operation.Division;
          break;
        case "Pow":
          currentStep.operation = Operation.Pow;
          break;
        case "SquareRoot":
          currentStep.operation = Operation.SquareRt;
          break;
        default:
          currentStep.operation = Operation.Addition;
          break;
      }

      if (xVal.Text.Length > 0)
        currentStep.x = double.Parse(xVal.Text);
      if (operationVal.Text == "t")
        currentStep.useT = true;
      else if (operationVal.Text.Length > 0)
      {
        currentStep.useT = false;
        currentStep.y = double.Parse(operationVal.Text);
      }

      fSaveStep(currentStep);
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      currentStep = steps[((ListBox) sender).SelectedIndex];
    }

    // dark mode (too lazy to rename)
    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (!dark)
      {
        foreach (Control c in Controls)
        {
          c.ForeColor = Color.White;
          c.BackColor = Color.Black;
        }
        ForeColor = Color.White;
        BackColor = Color.Black;
        richTextBox1.ForeColor = Color.White;
        richTextBox1.BackColor = Color.Black;
        richTextBox2.ForeColor = Color.White;
        richTextBox2.BackColor = Color.Black;
        chart1.ChartAreas[0].BackColor = Color.FromArgb(8,8,8);
        foreach (Axis a in chart1.ChartAreas[0].Axes)
        {
          a.MajorGrid.LineColor = Color.White;
          a.MinorGrid.LineColor = Color.White;
          a.LabelStyle.ForeColor = Color.White;
          a.LineColor = Color.White;
        }
      }
      else
      {
        foreach (Control c in Controls)
        {
          c.ForeColor = Color.Black;
          c.BackColor = Color.White;
        }
        ForeColor = Color.Black;
        BackColor = Color.White;
        richTextBox1.ForeColor = Color.Black;
        richTextBox1.BackColor = Color.White;
        richTextBox2.ForeColor = Color.Black;
        richTextBox2.BackColor = Color.White;
        chart1.ChartAreas[0].BackColor = Color.White;
        foreach (Axis a in chart1.ChartAreas[0].Axes)
        {
          a.MajorGrid.LineColor = Color.Black;
          a.MinorGrid.LineColor = Color.Black;
          a.LabelStyle.ForeColor = Color.Black;
          a.LineColor = Color.Black;
        }
      }
    
      dark = !dark;
    }
  }
}
