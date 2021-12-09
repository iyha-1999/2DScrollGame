using UnityEngine;
using Zenject;

public class UserInputInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Model.UserInput>().FromNew().AsCached();
        Container.Bind<Presenter.UserInput>().FromNew().AsCached().NonLazy();
    }
}