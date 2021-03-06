﻿namespace Spe.Abstractions.VersionDecoupling.Interfaces
{
    public interface IAuthenticationManager
    {
        bool Login(string username, string password);
        void Logout();
        bool IsAuthenticated { get; }
        string CurrentUsername { get; }
    }
}
