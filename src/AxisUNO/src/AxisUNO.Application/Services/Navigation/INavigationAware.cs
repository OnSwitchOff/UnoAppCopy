﻿namespace AxisUNO.Application.Services.Navigation;

public interface INavigationAware
{
    void OnNavigatedTo(object parameter);

    void OnNavigatedFrom();
}