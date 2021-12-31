using System.Collections.Generic;

namespace SGCServeur.Models
{
    public enum TypeCompteEnum
    {
        MEMBRE = 1,
        MANAGER = 2,
        ADMINISTRATEUR = 3
    }

    public static class TypeCompteHelper
    {
        public static TypeCompteEnum GetValueFromString(string name)
        {
            switch (name)
            {
                case nameof(TypeCompteEnum.MEMBRE):
                    return TypeCompteEnum.MEMBRE;
                case nameof(TypeCompteEnum.MANAGER):
                    return TypeCompteEnum.MANAGER;
                case nameof(TypeCompteEnum.ADMINISTRATEUR):
                    return TypeCompteEnum.ADMINISTRATEUR;
                default:
                    throw new KeyNotFoundException("La valeur indique ne fait pas partie des possibilites !");
            }
        }

        public static TypeCompteEnum GetValueFromInt(int type)
        {
            switch (type)
            {
                case (int)TypeCompteEnum.MEMBRE:
                    return TypeCompteEnum.MEMBRE;
                case (int)TypeCompteEnum.MANAGER:
                    return TypeCompteEnum.MANAGER;
                case (int)TypeCompteEnum.ADMINISTRATEUR:
                    return TypeCompteEnum.ADMINISTRATEUR;
                default:
                    throw new KeyNotFoundException("La valeur indique ne fait pas partie des possibilites !");
            }
        }

        public static string GetStringValueFromEnum(TypeCompteEnum type)
        {
            switch (type)
            {
                case TypeCompteEnum.MEMBRE:
                    return nameof(TypeCompteEnum.MEMBRE);
                case TypeCompteEnum.MANAGER:
                    return nameof(TypeCompteEnum.MANAGER);
                case TypeCompteEnum.ADMINISTRATEUR:
                    return nameof(TypeCompteEnum.ADMINISTRATEUR);
                default:
                    throw new KeyNotFoundException("La valeur indique ne fait pas partie des possibilites !");
            }
        }
    }
}
