using Terraria.ModLoader;

namespace UnusualStart
{
	class UnusualStart : Mod
	{
		public UnusualStart()
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
