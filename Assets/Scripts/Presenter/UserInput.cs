using UniRx;

namespace Presenter
{
    public class UserInput
    {
        Model.UserInput _model;
        View.UserInput _view;

        public UserInput(Model.UserInput model, View.UserInput view)
        {
            _model = model;
            _view = view;

            _view.horizontal.Subscribe(_ => _model.horizontal.SetValueAndForceNotify(_)).AddTo(_view);
            _view.vertical.Subscribe(_ => _model.vertical.SetValueAndForceNotify(_)).AddTo(_view);
        }
    }
}

