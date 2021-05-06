using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
  partial class Form1
  {

    private FlowLayoutPanel flowPanel;

    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Text = "LoginForm";

      Text = "Tooltips";
      ClientSize = new Size(800, 450);

      flowPanel = new FlowLayoutPanel();

      var ftip = new ToolTip();
      ftip.SetToolTip(flowPanel, "This is a FlowLayoutPanel");

      flowPanel.Dock = DockStyle.Fill;
      flowPanel.BorderStyle = BorderStyle.FixedSingle;

      var button = new Button();
      button.Text = "Button";
      button.AutoSize = true;

      var btip = new ToolTip();
      btip.SetToolTip(button, "This is a Button Control");

      var button2 = new Button();
      button2.Text = "Button 2";
      button2.AutoSize = true;

      flowPanel.Controls.Add(button);
      flowPanel.Controls.Add(button2);
      Controls.Add(flowPanel);

      CenterToScreen();
    }

    #endregion
  }
}

