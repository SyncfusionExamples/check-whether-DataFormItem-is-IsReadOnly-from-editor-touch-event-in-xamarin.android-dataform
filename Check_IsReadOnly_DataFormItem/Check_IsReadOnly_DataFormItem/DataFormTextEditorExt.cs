using System;
using Android.Views;
using Android.Widget;
using Syncfusion.Android.DataForm;
using Syncfusion.Android.DataForm.Editors;

namespace Check_IsReadOnly_DataFormItem
{
    public class DataFormTextEditorExt : DataFormTextEditor
    {
        public DataFormTextEditorExt(SfDataForm dataForm) : base(dataForm)
        {

        }

        protected override void OnWireEvents(EditText view)
        {
            view.Touch += OnTouch;
            base.OnWireEvents(view);
        }

        private void OnTouch(object sender, View.TouchEventArgs e)
        {
            var isReadOnly = ((sender as EditText).Parent as DataFormItemView).DataFormItem.IsReadOnly;
        }

        protected override void OnUnWireEvents(EditText view)
        {
            view.Touch -= OnTouch;
            base.OnUnWireEvents(view);
        }
    }
}
