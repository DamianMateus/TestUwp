using System;
using System.Threading.Tasks;

using TestUwp.Services;

using Windows.ApplicationModel.Activation;

namespace TestUwp.Activation
{
    internal class DefaultActivationHandler : ActivationHandler<IActivatedEventArgs>
    {
        private readonly Type _navElement;

        public DefaultActivationHandler(Type navElement)
        {
            _navElement = navElement;
        }

        protected override async Task HandleInternalAsync(IActivatedEventArgs args)
        {
            object arguments = null;
            if (args is LaunchActivatedEventArgs launchArgs)
            {
                arguments = launchArgs.Arguments;
            }

            NavigationService.Navigate(_navElement, arguments);
            await Task.CompletedTask;
        }

        protected override bool CanHandleInternal(IActivatedEventArgs args)
        {
            return NavigationService.Frame.Content == null && _navElement != null;
        }
    }
}
