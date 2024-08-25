using System;
using Cpp2ILInjected;

namespace Terraria.Graphics.CameraModifiers
{
	[global::Cpp2ILInjected.Token(Token = "0x2000770")]
	public interface ICameraModifier
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000792")]
		string UniqueIdentity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003E6C")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E6D")]
		void Update(ref CameraInfo cameraPosition);

		[global::Cpp2ILInjected.Token(Token = "0x17000793")]
		bool Finished
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003E6E")]
			get;
		}
	}
}
