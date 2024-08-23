using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

namespace Terraria
{
	// Token: 0x02000344 RID: 836
	[global::Cpp2ILInjected.Token(Token = "0x200045A")]
	public struct SceneMetricsScanSettings
	{
		// Token: 0x04002F4B RID: 12107
		[global::Cpp2ILInjected.Token(Token = "0x400372B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Rectangle? VisualScanArea;

		// Token: 0x04002F4C RID: 12108
		[global::Cpp2ILInjected.Token(Token = "0x400372C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Vector2? BiomeScanCenterPositionInWorld;

		// Token: 0x04002F4D RID: 12109
		[global::Cpp2ILInjected.Token(Token = "0x400372D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool ScanOreFinderData;
	}
}
