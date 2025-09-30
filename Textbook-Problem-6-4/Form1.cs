namespace Textbook_Problem_6_4
{
    public partial class form_main : Form
    {
        private CheckBox[] checkboxes;  //list of checkboxes, useful for handling button presses
        private TextBox[] textboxes;    //list of textboxes for same reason
        private int laborCharge = 75;   //hourly labor charge
        private double taxPercent = 0.06;   //tax rate for parts
        public form_main()
        {
            InitializeComponent();
            //initialize checkboxes
            checkboxes = new CheckBox[] {
                check_inspection, check_lubeJob, check_oilChange,
                check_radiatorFlush, check_replaceMuffler, check_tireRotation,
                check_transmissionFlush
            };
            textboxes = new TextBox[] {
                text_feesSummary, text_hours, text_parts, text_partsSummary,
                text_serviceLaborSummary, text_taxSummary
            };
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            //end the program
            Application.Exit();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            //call the form clearing method
            clearForm();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            //get all the individual costs and sum them up
            double serviceAndLabor = serviceAndLaborCost();
            double parts = partsCharges();
            double tax = taxCharges();
            double total = serviceAndLabor + parts + tax;

            //assign the right boxes the cost amounts they show
            text_serviceLaborSummary.Text = serviceAndLabor.ToString("C");
            text_partsSummary.Text = parts.ToString("C");
            text_taxSummary.Text = tax.ToString("C");
            text_feesSummary.Text = total.ToString("C");
        }

        //method to calculate service and labor cost
        private double serviceAndLaborCost()
        {
            //add up the value associated with every checkbox
            double serviceAndLabor = 0.0;
            serviceAndLabor += oilChangeCharges();
            serviceAndLabor += lubeJobCharges();
            serviceAndLabor += radiatorFlushCharges();
            serviceAndLabor += transmissionFlushCharges();
            serviceAndLabor += inspectionCharges();
            serviceAndLabor += replaceMufflerCharges();
            serviceAndLabor += tireRotationCharges();
            serviceAndLabor += laborCharges();
            return serviceAndLabor;
        }

        //a method to clear everything on the form
        private void clearForm()
        {
            //reset each checkbox to be false
            foreach (CheckBox check in checkboxes)
            {
                check.Checked = false;
            }
            //reset each textbox to be blank
            foreach (TextBox text in textboxes)
            {
                text.Clear();
            }
        }


        //a set of methods to return the respective charges for a box
        private int oilChangeCharges()
        {
            return check_oilChange.Checked ? 50 : 0;
        }
        private int lubeJobCharges()
        {
            return check_lubeJob.Checked ? 40 : 0;
        }
        private int radiatorFlushCharges()
        {
            return check_radiatorFlush.Checked ? 100 : 0;
        }
        private int transmissionFlushCharges()
        {
            return check_transmissionFlush.Checked ? 120 : 0;
        }
        private int inspectionCharges()
        {
            return check_inspection.Checked ? 20 : 0;
        }
        private int replaceMufflerCharges()
        {
            return check_replaceMuffler.Checked ? 150 : 0;
        }
        private int tireRotationCharges()
        {
            return check_tireRotation.Checked ? 25 : 0;
        }
        private int partsCharges()
        {
            int charge;
            try
            {
                charge = int.Parse(text_parts.Text);
                return charge;
            }
            catch (Exception)
            {
                //should the parts cost be an invalid value, just set the box blank and treat the value as 0.
                text_parts.Text = "";
                return 0;
            }
        }
        private int laborCharges()
        {
            int hours;
            try
            {
                hours = int.Parse(text_hours.Text);
                return hours * laborCharge;
            }
            catch (Exception)
            {
                //should the hours be an invalid value, just set the box blank and treat the value as 0.
                text_hours.Text = "";
                return 0;
            }
        }
        private double taxCharges()
        {
            return partsCharges() * taxPercent;
        }

        
    }
}
