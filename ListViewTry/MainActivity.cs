using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Android.Util;
using System;
using Android.Content;

namespace ListViewTry
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, Icon ="@mipmap/ic_launcher")]
    public class MainActivity : AppCompatActivity
    {
        static readonly string Tag = "ListSupport";
        private List<Person> itemStrings;
        private ListView firstListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            firstListView = FindViewById<ListView>(Resource.Id.lstFirstList);

            itemStrings = new List<Person>();
            itemStrings.Add(new Person() { FirstName = "Dev", LastName = "Watmore", Age = "75", Gender = "Male" });
            itemStrings.Add(new Person() { FirstName = "Arjuna", LastName = "Ranatunga", Age = "65", Gender = "Male" });
            itemStrings.Add(new Person() { FirstName = "Aravinda", LastName = "De Silva", Age = "66", Gender = "Male" });

            ListViewFirstAdapter listViewFirstAdapter = new ListViewFirstAdapter(this, itemStrings);

            firstListView.Adapter = listViewFirstAdapter;

            firstListView.ItemClick += FirstListView_ItemClick;
        }

        private void FirstListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var view = (ListView) sender;
            var item = itemStrings[e.Position];
            Log.Debug(Tag, "The row {0} {1} {2} {3} has been selected.", item.FirstName, item.LastName, item.Age, item.Gender);

            Intent nextActivity = new Intent(this, typeof(ActivityRowDetails));

            nextActivity.PutExtra("name", item.FirstName);
            nextActivity.PutExtra("lastName", item.LastName);
            nextActivity.PutExtra("age", item.Age);
            nextActivity.PutExtra("gender", item.Gender);

            StartActivity(nextActivity);
        }
    }
}