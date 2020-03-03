// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------


namespace System.IdentityModel.Tokens
{
    public class Saml2AssertionKeyIdentifierClause : SecurityKeyIdentifierClause
    {
        public Saml2AssertionKeyIdentifierClause(string assertionId) : base(assertionId, null, 0) { }
        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause) => default;
        public override string ToString() => default;
        public static bool Matches(string assertionId, SecurityKeyIdentifierClause keyIdentifierClause) => default;
    }
    public class SamlAssertionKeyIdentifierClause : SecurityKeyIdentifierClause
    {
        public SamlAssertionKeyIdentifierClause(string assertionId) : base(assertionId, null, 0) { }
        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause) => default;
        public override string ToString() => default;
        public static bool Matches(string assertionId, SecurityKeyIdentifierClause keyIdentifierClause) => default;
    }
}

namespace System.ServiceModel.Federation
{
    internal class WsFederationBindingElement : BindingElement
    {
        public WsFederationBindingElement(WsTrustTokenParameters wsTrustTokenParameters, System.ServiceModel.Channels.SecurityBindingElement securityBindingElement) { }
        public WsTrustTokenParameters WsTrustTokenParameters { get => default; }
        public System.ServiceModel.Channels.SecurityBindingElement SecurityBindingElement { get => default; }
        public override System.ServiceModel.Channels.BindingElement Clone() => default;
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) => default;
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) => default;
    }
    public class WsFederationHttpBinding : WSHttpBinding
    {
        public WsFederationHttpBinding(WsTrustTokenParameters wsTrustTokenParameters) : base(System.ServiceModel.SecurityMode.TransportWithMessageCredential) { }
        public WsTrustTokenParameters WsTrustTokenParameters { get => default; }
        protected override System.ServiceModel.Channels.SecurityBindingElement CreateMessageSecurity() => default;
        public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() => default;
        protected override System.ServiceModel.Channels.TransportBindingElement GetTransport() => default;
    }
    public class WsTrustChannelClientCredentials : ClientCredentials
    {
        public WsTrustChannelClientCredentials() : base() { }
        public WsTrustChannelClientCredentials(ClientCredentials clientCredentials) : base(clientCredentials) { }
        protected WsTrustChannelClientCredentials(WsTrustChannelClientCredentials other) : base(other) { }
        public ClientCredentials ClientCredentials { get => default; private set { } }
        protected override ClientCredentials CloneCore() => default;
        public override SecurityTokenManager CreateSecurityTokenManager() => default;
    }
    public class WsTrustChannelSecurityTokenManager : System.ServiceModel.ClientCredentialsSecurityTokenManager
    {
        public WsTrustChannelSecurityTokenManager(WsTrustChannelClientCredentials wsTrustChannelClientCredentials) : base(wsTrustChannelClientCredentials) { }
        public override System.IdentityModel.Selectors.SecurityTokenProvider CreateSecurityTokenProvider(System.IdentityModel.Selectors.SecurityTokenRequirement tokenRequirement) => default;
    }
    public class WsTrustChannelSecurityTokenProvider : SecurityTokenProvider
    {
        public WsTrustChannelSecurityTokenProvider(SecurityTokenRequirement tokenRequirement) { }
        protected virtual WsTrustRequest CreateWsTrustRequest() => default;
        protected override SecurityToken GetTokenCore(TimeSpan timeout) => default;
        public override bool SupportsTokenCancellation => default;
        public override bool SupportsTokenRenewal => default;
    }
    public class WsTrustTokenParameters : IssuedSecurityTokenParameters
    {
        public static readonly bool DefaultCacheIssuedTokens = default;
        public static readonly int DefaultIssuedTokenRenewalThresholdPercentage = default;
        public static readonly TimeSpan DefaultMaxIssuedTokenCachingTime = default;
        public static readonly SecurityKeyType DefaultSecurityKeyType = default;
        public WsTrustTokenParameters() { }
        protected WsTrustTokenParameters(WsTrustTokenParameters other) : base(other) { }
        protected override SecurityTokenParameters CloneCore() => default;
        public ICollection<XmlElement> AdditionalRequestParameters => default;
        public bool CacheIssuedTokens { get => default; set { } }
        public ICollection<ClaimType> ClaimTypes => default;
        public int IssuedTokenRenewalThresholdPercentage => default;
        public int? KeySize { get => default; set { } }
        public TimeSpan MaxIssuedTokenCachingTime { get => default; set { } }
        public MessageSecurityVersion MessageSecurityVersion { get => default; set { } }
        public string RequestContext { get => default; set { } }
        public string Target { get => default; set { } }
        public bool EstablishSecurityContext { get => default; set { } }
    }
}
