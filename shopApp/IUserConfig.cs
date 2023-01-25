using System;

namespace shopApp
{
    public interface IUserConfig
    {
        void ConsulterInfos();
        void ModifierInfos();
        void SupprimerCompte(int id);
    }
}
