using Terraria.ModLoader;

namespace RedDawn
{
	class RedDawn : Mod
	{
		public RedDawn()
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
