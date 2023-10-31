﻿namespace SimpleIdServer.Mobile.Services;

public interface INavigationService
{
    Task GoBack();
    Task DisplayModal<T>() where T : ContentPage;
}

public class NavigationService : INavigationService
{
    private readonly INavigation _navigation;
    private readonly IServiceProvider _serviceProvider;

    public NavigationService(IServiceProvider serviceProvider)
    {
        _navigation = App.Current.MainPage.Navigation;
        _serviceProvider = serviceProvider;
    }

    public Task GoBack()
    {
        return App.Current.Dispatcher.DispatchAsync(async () =>
        {
            await Shell.Current.GoToAsync("..");
        });
    }

    public Task DisplayModal<T>() where T : ContentPage
    {
        var service = _serviceProvider.GetRequiredService<T>();
        return _navigation.PushModalAsync(service);
    }
}
