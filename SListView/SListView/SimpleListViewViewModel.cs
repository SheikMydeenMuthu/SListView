using SListView.Model;
using SListView.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SListView
{
    public class SimpleListViewViewModel : BaseViewModel
    {
        private List<ListModel> listViewCollection;

        public List<ListModel> ListViewCollection
        {
            get
            {
                return listViewCollection;
            }
            set
            {
                listViewCollection = value;
                OnPropertChanged();
            }
        }

        public SimpleListViewViewModel()
        {
            ListViewCollection = BindListView();
        }

        private List<ListModel> BindListView()
        {
            List<ListModel> listModel = new List<ListModel>();

            listModel.Add(new ListModel { Title = "List 1", SubTitle = "List 1 SubTitle" });
            listModel.Add(new ListModel { Title = "List 2", SubTitle = "List 2 SubTitle" });
            listModel.Add(new ListModel { Title = "List 3", SubTitle = "List 3 SubTitle" });

            return listModel;

        }
    }
}
