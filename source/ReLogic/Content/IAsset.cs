using System;
using Cpp2ILInjected;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B48")]
	public interface IAsset : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700091B")]
		AssetState State
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005407")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700091C")]
		IContentSource Source
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005408")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700091D")]
		string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005409")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700091E")]
		bool IsLoaded
		{
			[global::Cpp2ILInjected.Token(Token = "0x600540A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700091F")]
		bool IsDisposed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600540B")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600540C")]
		void ActionUnityLoad();
	}
}
