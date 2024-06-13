namespace sortirovka
{
    public partial class Form1 : Form
    {
        private List<Button> listButt;
        public Form1()
        {
            InitializeComponent();
            listButt = new()
            {
                button1,
                button2,
                button3,
                button4,
                button5,
            };
        }
        private void button5_Click(object sender, EventArgs e)
        {
                listButt =listButt.OrderBy(butt=> gg(butt.Location.X,butt.Location.Y)).ToList();
            for(int i=0; i<listButt.Count; i++)
            {
                listButt[i].Text=i.ToString();
            }

        }
        private double gg(int X,int Y) => Math.Sqrt(X*X + Y*Y);
        

        
    }
} 