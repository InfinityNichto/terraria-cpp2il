using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x2000454")]
	public abstract class SettingsBase
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E96ADC", Offset = "0x1E96ADC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected SettingsBase()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006BF")]
		public virtual SettingsContext Context
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E05")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E96B14", Offset = "0x1E96B14", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006C0")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E96B4C", Offset = "0x1E96B4C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006C1")]
		public virtual object this[string propertyName]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E07")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E96B84", Offset = "0x1E96B84", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001E08")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E96BBC", Offset = "0x1E96BBC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006C2")]
		public virtual SettingsPropertyCollection Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E09")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E96BF4", Offset = "0x1E96BF4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006C3")]
		public virtual SettingsPropertyValueCollection PropertyValues
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E96C2C", Offset = "0x1E96C2C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006C4")]
		public virtual SettingsProviderCollection Providers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E0B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E96C64", Offset = "0x1E96C64", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E96C9C", Offset = "0x1E96C9C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Initialize(SettingsContext context, SettingsPropertyCollection properties, SettingsProviderCollection providers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E96CD4", Offset = "0x1E96CD4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void Save()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E96D0C", Offset = "0x1E96D0C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Properties.Settings", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static SettingsBase Synchronized(SettingsBase settingsBase)
		{
			throw null;
		}
	}
}
