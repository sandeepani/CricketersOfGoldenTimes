using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace ListViewTry
{
    [Activity(Label = "ActivityRowDetails")]
    public class ActivityRowDetails: Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_row_details);

            string name = Intent.GetStringExtra("name" ?? "Not recv");
            var txtName2 = FindViewById<TextView>(Resource.Id.txtName2);
            txtName2.Text = name;

            string lastName = Intent.GetStringExtra("lastName" ?? "Not recv");
            var txtLastName2 = FindViewById<TextView>(Resource.Id.txtLastName2);
            txtLastName2.Text = lastName;

            string age = Intent.GetStringExtra("age" ?? "Not recv");
            var txtAge2 = FindViewById<TextView>(Resource.Id.txtAge2);
            txtAge2.Text = age;

            string gender = Intent.GetStringExtra("gender" ?? "Not recv");
            var txtGender2 = FindViewById<TextView>(Resource.Id.txtGender2);
            txtGender2.Text = gender;

            switch (name)
            {
                case "Dev":
                    FindViewById<TextView>(Resource.Id.txtDetails).Text = "Davenell Frederick 'Dav' Whatmore is an Australian cricket coach and former cricketer who is current coach of Kerala cricket team. A right-handed batsman, Whatmore played seven Test matches for Australia in 1979, and one One Day International in 1980.At first -class level, he scored over 6,000 runs for Victoria. ";
                    break;
                case "Arjuna":
                    FindViewById<TextView>(Resource.Id.txtDetails).Text = "Deshamanya Arjuna Ranatunga is a former Sri Lankan cricketer and 1996 Cricket World Cup winning captain for Sri Lanka. Often nicknamed as Captain Cool, he is regarded as the pioneer to lift Sri Lankan cricket from underdog status to one of great forces in cricketing world";
                    break;
                case "Aravinda":
                    FindViewById<TextView>(Resource.Id.txtDetails).Text = "Deshabandu Pinnaduwage Aravinda de Silva is a former Sri Lankan cricketer and former captain. He has also played in English county cricket. ";
                    break;
                default:
                    break;
            }

            FindViewById<Button>(Resource.Id.btnPrevious).Click += delegate { this.Finish(); };
        }

    }
}