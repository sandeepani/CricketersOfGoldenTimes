using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListViewTry
{
    class ListViewFirstAdapter : BaseAdapter<Person>
    {

        private Context context;
        private List<Person> items;

        public ListViewFirstAdapter(Context context, List<Person> items)
        {
            this.context = context;
            this.items = items;
        }


        public override Java.Lang.Object GetItem(int position)
        {
            return items[position];
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            //-----------With holder----------------
            ListViewFirstAdapterViewHolder holder = null;

            if (view != null)
                holder = view.Tag as ListViewFirstAdapterViewHolder;


            if (holder == null)
            {
                holder = new ListViewFirstAdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //comment back in
                view = inflater.Inflate(Resource.Layout.listview_row, parent, false);
                holder.FirstName = view.FindViewById<TextView>(Resource.Id.txtName);
                holder.LastName = view.FindViewById<TextView>(Resource.Id.txtLastName);
                holder.Age = view.FindViewById<TextView>(Resource.Id.txtAge);
                holder.Gender = view.FindViewById<TextView>(Resource.Id.txtGender);
                view.Tag = holder;
            }


            //fill in items
            holder.FirstName.Text = items[position].FirstName;
            holder.LastName.Text = items[position].LastName;
            holder.Age.Text = items[position].Age;
            holder.Gender.Text = items[position].Gender;

            if (view == null)
                view = LayoutInflater.From(context).Inflate(Resource.Layout.listview_row, null, false);

            //-----------Without Holder-----------------
            //TextView Name = view.FindViewById<TextView>(Resource.Id.txtName);
            //Name.Text = items[position];

            return view;
        }

        //Returns count
        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override Person this[int position] => items[position];
    }

    class ListViewFirstAdapterViewHolder : Java.Lang.Object
    {
        //adapter views to re-use
        public TextView FirstName { get; set; }
        public TextView LastName { get; set; }
        public TextView Age { get; set; }
        public TextView Gender { get; set; }
    }
}