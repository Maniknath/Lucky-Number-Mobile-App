using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Java.Util;

namespace LuckyNumber
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, Icon = "@mipmap/ic_launcher1")]
    public class MainActivity : AppCompatActivity
    {
        SeekBar seekBar;
        TextView resultTextView;
        Button rollButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            seekBar = FindViewById<SeekBar>(Resource.Id.seekBar);
            resultTextView = FindViewById<TextView>(Resource.Id.resultTextView);
            //resultTextView.Text = "9";
            rollButton = (Button)FindViewById(Resource.Id.rollButton);
            rollButton.Click += RollButton_Click;

            SupportActionBar.Title = "MY LUCKY NUMBER";

        }

        private void RollButton_Click(object sender, System.EventArgs e)
        {
            Random random = new Random();

            int luckyNumber = random.NextInt(seekBar.Progress) + 1;
            resultTextView.Text = luckyNumber.ToString();
        }
    }
}