//  This file was created by Kamil KAYA
//  Ozyegin University - Electric Electronic Engineering
//  www.kamilkaya.com.tr

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirimCevirici
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private bool crossing = false;
        new convertorClass Proccess = new convertorClass();
        private void select_proccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select_proccess.SelectedIndex >= 0) {
                input_unit.Enabled = true;
                input_value.Enabled = true;
                output_unit.Enabled = true;
                cross.Enabled = true;
            }

            switch (select_proccess.SelectedIndex) { 

            case 0:
                    input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("m");
                    input_unit.Items.Add("cm");
                    input_unit.Items.Add("mm");
                    input_unit.SelectedIndex = 0;
                    output_unit.Items.Add("in");
                    output_unit.Items.Add("ft");
                    output_unit.SelectedIndex = 0;                    
                    break;
            case 1:
                    input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("m^2");
                    input_unit.Items.Add("cm^2");
                    input_unit.Items.Add("mm^2");
                    output_unit.Items.Add("in^2");
                    output_unit.Items.Add("ft^2");
                    input_unit.SelectedIndex = 0;
                    output_unit.SelectedIndex = 0;
                    break;
            case 2:
                    input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("m^3");
                    input_unit.Items.Add("cm^3");
                    input_unit.Items.Add("mm^3");
                    output_unit.Items.Add("in^3");
                    output_unit.Items.Add("ft^3");
                    input_unit.SelectedIndex = 0;
                    output_unit.SelectedIndex = 0;
                    
                    break;
            case 3:
                    input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("m^4");
                    input_unit.Items.Add("cm^4");
                    input_unit.Items.Add("mm^4");
                    output_unit.Items.Add("in^4");
                    output_unit.Items.Add("ft^4");
                    input_unit.SelectedIndex = 0;
                    output_unit.SelectedIndex = 0;
                    
                break;
            case 4:
                    input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("kg");
                    output_unit.Items.Add("slug");
                    output_unit.Items.Add("lbm");
                    input_unit.SelectedIndex = 0;
                    output_unit.SelectedIndex = 0;
                   
                break;
            case 5:
               input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("kg/m^3");
                    output_unit.Items.Add("slug/ft^3");
                    output_unit.Items.Add("lb/ft^3");
                    input_unit.SelectedIndex = 0;
                    output_unit.SelectedIndex = 0;
                   break;
            case 6:
                input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("N");
                    output_unit.Items.Add("lb");
                    input_unit.SelectedIndex = 0;
                    output_unit.SelectedIndex = 0;
                   break;
            case 7:
                input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("N.m");
                    output_unit.Items.Add("in.lb");
                    output_unit.Items.Add("ft.lb");
                    input_unit.SelectedIndex = 0;
                    output_unit.SelectedIndex = 0;;
                break;
            case 8:
                input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("Pa");
                    output_unit.Items.Add("lb/in^2");
                    input_unit.SelectedIndex = 0;
                    output_unit.SelectedIndex = 0;;
                break;
            case 9:
                input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("Pa");
                    output_unit.Items.Add("lb/ft^2");
                    input_unit.SelectedIndex = 0;
                    output_unit.SelectedIndex = 0;;;
                break;
            case 10:
                input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("kPa");
                    output_unit.Items.Add("ksi");
                    input_unit.SelectedIndex = 0;
                    output_unit.SelectedIndex = 0;;;
                break;
            case 11:
               input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("J");
                    input_unit.Items.Add("kWh");
                    output_unit.Items.Add("ft.lb");
                    output_unit.Items.Add("Btu");
                    input_unit.SelectedIndex = 0;
                    output_unit.SelectedIndex = 0;
                break;
            case 12:
                input_unit.Items.Clear();
                    output_unit.Items.Clear();
                    input_unit.Items.Add("W");
                    input_unit.Items.Add("kW");
                    output_unit.Items.Add("ft.lb/s");
                    output_unit.Items.Add("Btu/h");
                    output_unit.Items.Add("hp");
                    input_unit.SelectedIndex = 0;
                    output_unit.SelectedIndex = 0;
                break;
            case 13:
                input_unit.Items.Clear();
                output_unit.Items.Clear();
                input_unit.Items.Add("Santigrad");
                output_unit.Items.Add("Fahrenheit");
                input_unit.SelectedIndex = 0;
                output_unit.SelectedIndex = 0;
             break;

            }
        }

        double input_coefficient;
        double output_coefficient;

        private void make()
        {
            try
            {
                switch (select_proccess.SelectedIndex)
                {

                    case 0:
                        switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                            case 1:
                                input_coefficient = 0.01;
                                break;
                            case 2:
                                input_coefficient = 0.001;
                                break;
                        }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 39.37;
                                break;
                            case 1:
                                output_coefficient = 3.28;
                                break;
                        }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }

                        break;
                    case 1:

                        switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                            case 1:
                                input_coefficient = 0.0001;
                                break;
                            case 2:
                                input_coefficient = 0.000001;
                                break;
                        }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 1550;
                                break;
                            case 1:
                                output_coefficient = 10.76;
                                break;
                        }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }
                        break;
                    case 2:
                        switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                            case 1:
                                input_coefficient = 0.000001;
                                break;
                            case 2:
                                input_coefficient = 0.0000001;
                                break;
                        }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 61024;
                                break;
                            case 1:
                                output_coefficient = 35.315;
                                break;
                        }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }

                        break;
                    case 3:
                        switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                            case 1:
                                input_coefficient = 0.00000001;
                                break;
                            case 2:
                                input_coefficient = 0.000000000001;
                                break;
                        }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 2402509.61;
                                break;
                            case 1:
                                output_coefficient = 115.86;
                                break;
                        }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }
                        break;
                    case 4:
                              switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                            
                         }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 0.068521;
                                break;
                            case 1:
                                output_coefficient = 2.2046;
                                break;
                        }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }
                        break;
                    case 5:
                              switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                            
                         }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 0.001938;
                                break;
                            case 1:
                                output_coefficient = 0.06248;
                                break;
                        }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }
                        break;
                    case 6:
                                switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                            
                         }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 0.224809;
                                break;
                            }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }
                        break;
                    case 7:
                                  switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                           
                         }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 8.85;
                                break;
                            case 1:
                                output_coefficient = 0.7376;
                                break;
                            }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }
                        break;
                    case 8:
                                 switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                           
                         }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 0.000145;
                                break;
                            }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }
                        break;
                    case 9:
                                   switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                           
                         }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 0.02088;
                                break;
                            }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }
                        break;
                    case 10:
                                     switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                           
                         }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 0.000145;
                                break;
                            }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }
                        break;
                    case 11:
                          switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                            case 1:
                                input_coefficient = 0.000000277;
                                break;
                           
                           }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 0.7375;
                                break;
                            case 1:
                                output_coefficient = 3412.14000;
                                break;
                        }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }

                        break;
                    case 12:
                         switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;
                            case 1:
                                input_coefficient = 1000;
                                break;
                           
                        }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 0.7375;
                                break;
                            case 1:
                                output_coefficient = 3412.14;
                                break;
                            case 2:
                                output_coefficient = 1.341;
                                break;
                        }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateLength(double.Parse(input_value.Text), input_coefficient, output_coefficient, crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateLength(double.Parse(output_value.Text), output_coefficient, input_coefficient, crossing)).ToString();
                        }
                        break;
                    case 13:
                          switch (input_unit.SelectedIndex)
                        {
                            case 0:
                                input_coefficient = 1;
                                break;                      
                        }

                        switch (output_unit.SelectedIndex)
                        {
                            case 0:
                                output_coefficient = 1;
                                break;
                           }

                        if (!crossing)
                        {
                            output_value.Text = (Proccess.calculateTemparature(double.Parse(input_value.Text), crossing)).ToString();
                        }
                        else
                        {
                            input_value.Text = (Proccess.calculateTemparature(double.Parse(output_value.Text), crossing)).ToString();
                        }
                        break;
                }


            }
            catch (Exception te)
            {
                MessageBox.Show("Lütfen Sayısal Bir Değer Giriniz.", " Hatalı Giriş Yaptınız");
            }
        }

        private void cross_Click(object sender, EventArgs e)
        {
            if (crossing == false)
            {
                crossing = true;
                cross.Text = "<-";
                output_value.Enabled = true;
                input_value.Enabled = false;

            }
            else {
                crossing = false;
                cross.Text = "->";
                output_value.Enabled = false;
                input_value.Enabled = true;
            }
            make();
        }

        private void input_value_TextChanged(object sender, EventArgs e)
        {
            make();
        }

        private void output_value_TextChanged(object sender, EventArgs e)
        {
            make();
        }

        private void input_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            make();
        }

        private void output_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            make();
        }
    }
}
