using Caliburn.Micro;
using RMSDesktopUI.EventModels;
using System.Threading;
using System.Threading.Tasks;

namespace RMSDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private readonly IEventAggregator _events;
        private readonly SalesViewModel _salesVm;
        private readonly SimpleContainer _container;

        public ShellViewModel(IEventAggregator events, SalesViewModel salesVm, SimpleContainer container)
        {
            _events = events;
            _salesVm = salesVm;
            _container = container;

            _events.SubscribeOnUIThread(this);

            ActivateItemAsync(_container.GetInstance<LoginViewModel>());
        }

        public Task HandleAsync(LogOnEvent message, CancellationToken cancellationToken)
        {
            return ActivateItemAsync(_salesVm, cancellationToken);
        }
    }
}
