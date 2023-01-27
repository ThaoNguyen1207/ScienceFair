using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScienceFair
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuildButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BuildButton
            // 
            this.BuildButton.AutoSize = true;
            this.BuildButton.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildButton.Location = new System.Drawing.Point(25, 638);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(160, 33);
            this.BuildButton.TabIndex = 0;
            this.BuildButton.Text = "Check For Errors";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.ClickThisButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.Location = new System.Drawing.Point(762, 638);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(163, 33);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Launch .exe File";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(539, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(386, 231);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Error and Grade:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(25, 61);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(396, 491);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(961, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 698);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(961, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(961, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip1";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(539, 321);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(386, 231);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Compiled error-free:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 720);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.BuildButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;


        private void BuildButton_Click (object sender, System.EventArgs e)
        {
            CSharpCodeProvider codeProvider= new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            string Output = "Out.exe";
            System.Windows.Forms.Button ButtonObject = (System.Windows.Forms.Button)sender;
            textBox1.Text = "";
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();

            //generate an EXE

            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, textBox2.Text);

            if (results.Errors.Count > 0 )
            {

                //add lines of code pasted in textBox2 into an array
                string[] codeLines = textBox2.Lines;

                //clears the sucessful compile box
                textBox3.Text = " "; 

                int grade = 100 - results.Errors.Count;

                textBox1.ForeColor = System.Drawing.Color.Red;

                foreach (CompilerError CompErr in results.Errors)
                {
                    int index = CompErr.Line - 1;
                    string error = codeLines[index];
                    

                    // displays the error
                    textBox1.Text = textBox1.Text + "Error found at line number " + CompErr.Line +
                        ", Error Number: " + CompErr.ErrorNumber +
                        ", " + CompErr.ErrorText + "." +
                        Environment.NewLine + Environment.NewLine;

                    //fixes common errors automatically, this is missing semicolon error
                    if (CompErr.ErrorNumber == "CS1002")
                    {
                        string fixedError = error + ";";
                        codeLines[index] = fixedError;

                        textBox1.Text = textBox1.Text;
                       
                        textBox2.Text = string.Join(Environment.NewLine, codeLines);


                    }

                    if (CompErr.ErrorNumber == "CS1513")
                    {
                        string x = error + "}";
                        codeLines[index] = x;

                        textBox1.Text = textBox1.Text;

                        textBox2.Text = string.Join(Environment.NewLine, codeLines);
                    }


                    if (results.Errors.Count == 1)
                    {
                        
                        textBox1.Text = textBox1.Text + "1 error found, student's grade is: " + grade + "." + Environment.NewLine;
                    }
                    
                }

                if (results.Errors.Count > 1)
                {
             
                    textBox1.Text = textBox1.Text + results.Errors.Count + " errors found, student's grade is: " + grade + "." + Environment.NewLine;
                }

                // textBox1.Text = "You have " + results.Errors.Count + " error(s), your grade is: " + grade + ".";


            }
            else
            {
                //if compiled successfully
                textBox1.Text = textBox1.Text;
                textBox3.ForeColor = System.Drawing.Color.Green;
                textBox3.Text = "Successfully Compiled!" + Environment.NewLine + "Student's grade is 100.";

                //if click launch .exe file then launch EXE
                if (ButtonObject.Text == "Launch .exe File") Process.Start(Output);
            }


        }

        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip2;
      
    }
}

