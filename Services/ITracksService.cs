﻿using Lab3_.ViewModels;

namespace Lab3_.Services
{
    public interface ITracksService
    {
        HomeViewModel GetHomeViewModel(int numberRows = 10);
    }
}