using System;
using Cpp2ILInjected;

namespace Terraria.Graphics.CameraModifiers
{
	// Token: 0x0200050A RID: 1290
	[global::Cpp2ILInjected.Token(Token = "0x2000770")]
	public interface ICameraModifier
	{
		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060037D0 RID: 14288
		[global::Cpp2ILInjected.Token(Token = "0x17000792")]
		string UniqueIdentity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003E6C")]
			get;
		}

		// Token: 0x060037D1 RID: 14289
		[global::Cpp2ILInjected.Token(Token = "0x6003E6D")]
		void Update(ref CameraInfo cameraPosition);

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060037D2 RID: 14290
		[global::Cpp2ILInjected.Token(Token = "0x17000793")]
		bool Finished
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003E6E")]
			get;
		}
	}
}
