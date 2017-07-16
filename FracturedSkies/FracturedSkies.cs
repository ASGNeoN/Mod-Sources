using Terraria.ModLoader;

namespace FracturedSkies
{
	class FracturedSkies : Mod
	{
		public FracturedSkies()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
