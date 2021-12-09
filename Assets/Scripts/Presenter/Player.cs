using UniRx;

namespace Presenter
{
    public class Player
    {
        Model.Player _playerModel;
        Model.UserInput _userInputModel;

        View.Player _playerView;

        public Player(Model.Player playerModel, Model.UserInput userInputModel, View.Player playerView)
        {
            //**model**
            _playerModel = playerModel;
            _userInputModel = userInputModel;

            //**view**
            _playerView = playerView;


            //input
            _userInputModel.horizontal.Subscribe(_ =>
            {
                _playerModel.SetForce(_userInputModel.GetVector3FromAxis());
            }).AddTo(_playerView);
            _userInputModel.vertical.Subscribe(_ =>
            {
                _playerModel.SetForce(_userInputModel.GetVector3FromAxis());
            }).AddTo(_playerView);


            //force
            _playerModel.force.Skip(1).Subscribe(_ => _playerView.SerForce(_)).AddTo(_playerView);
            _playerModel.forceSpeed.Skip(1).Subscribe(_ => _playerModel.force.Value *= _).AddTo(_playerView);
        }
    }
}