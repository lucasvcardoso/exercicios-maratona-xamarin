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

namespace ListViewDemo
{
    public class EmployeeAdapter : BaseAdapter<Employee>
    {
        Employee[] _data;
        public EmployeeAdapter(Employee[] data)
        {
            _data = data;
        }

        public override Employee this[int position]
        {
            get
            {
                return _data[position];
            }
        }

        public override int Count
        {
            get
            {
                return _data.Count();
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var inflater = LayoutInflater.From(parent.Context);
            var view = inflater.Inflate(Resource.Layout.EmployeeItem, parent, false);

            var txvName = view.FindViewById<TextView>(Resource.Id.txvName);
            var txvEmail = view.FindViewById<TextView>(Resource.Id.txvEmail);

            txvName.Text = _data[position].Name;
            txvEmail.Text = _data[position].Email;

            return view;
        }
    }
}