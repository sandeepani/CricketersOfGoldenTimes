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

            string name = SetUIElement("name", Resource.Id.txtName2);
            SetUIElement("lastName", Resource.Id.txtLastName2);
            SetUIElement("age", Resource.Id.txtAge2);
            SetUIElement("gender", Resource.Id.txtGender2);

            var details = FindViewById<TextView>(Resource.Id.txtDetails).Text;
            switch (name)
            {
                case "Dev":
                    details = "Davenell Frederick 'Dav' Whatmore is an Australian cricket coach and former cricketer who is current coach of Kerala cricket team. A right-handed batsman, Whatmore played seven Test matches for Australia in 1979, and one One Day International in 1980.At first -class level, he scored over 6,000 runs for Victoria. ";
                    break;
                case "Arjuna":
                    details = "Deshamanya Arjuna Ranatunga is a former Sri Lankan cricketer and 1996 Cricket World Cup winning captain for Sri Lanka. Often nicknamed as Captain Cool, he is regarded as the pioneer to lift Sri Lankan cricket from underdog status to one of great forces in cricketing world";
                    break;
                case "Aravinda":
                    details = "Deshabandu Pinnaduwage Aravinda de Silva is a former Sri Lankan cricketer and former captain. He has also played in English county cricket. ";
                    break;
                default:
                    break;
            }

            FindViewById<Button>(Resource.Id.btnPrevious).Click += delegate { this.Finish(); };
        }

        private string SetUIElement(string nameString, int resource)
        {
            string name = Intent.GetStringExtra(nameString ?? "Not recv");
            var txtName = FindViewById<TextView>(resource);
            txtName.Text = name;
            return name;
        }
    }
}