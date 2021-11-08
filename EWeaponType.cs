using System.ComponentModel;

namespace TP2
{
    public enum EWeaponType
    {
        [Description("Direct weapon")]
        Direct,
        [Description("Explosive weapon")]
        Explosive,
        [Description("Guided weapon")]
        Guided
    }
}
