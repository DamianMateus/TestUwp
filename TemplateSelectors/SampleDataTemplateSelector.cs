using TestUwp.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TestUwp.TemplateSelectors
{
    public class SampleDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ProfessorTemplate { get; set; }

        public DataTemplate AssignatureTemplate { get; set; }

        public DataTemplate StudentsTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            return GetTemplate(item) ?? base.SelectTemplateCore(item);
        }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            return GetTemplate(item) ?? base.SelectTemplateCore(item, container);
        }

        private DataTemplate GetTemplate(object item)
        {
            switch (item)
            {
                case Professor professor:
                    return ProfessorTemplate;
                case Assignature assignature:
                    return AssignatureTemplate;
                case Students students:
                    return StudentsTemplate;
            }

            return null;
        }
    }
}
