using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x200045A")]
	public struct SceneMetricsScanSettings
	{
		[global::Cpp2ILInjected.Token(Token = "0x400372B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Rectangle? VisualScanArea;

		[global::Cpp2ILInjected.Token(Token = "0x400372C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Vector2? BiomeScanCenterPositionInWorld;

		[global::Cpp2ILInjected.Token(Token = "0x400372D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool ScanOreFinderData;
	}
}
