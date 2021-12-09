using Zenject;

public class PlayerInstaller : MonoInstaller
{

    public override void InstallBindings()
    {
        Container.Bind<Model.Player>().FromNew().AsCached();
        Container.Bind<Presenter.Player>().FromNew().AsCached().NonLazy();
    }
}