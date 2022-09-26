using System;
using System.Collections.Generic;

namespace FamilyHubs.IdentityServerHost.Pages.Grants;

public class ViewModel
{
    public IEnumerable<GrantViewModel> Grants { get; set; } = default!;
}

public class GrantViewModel
{
    public string ClientId { get; set; } = default!;
    public string ClientName { get; set; } = default!;
    public string ClientUrl { get; set; } = default!;
    public string ClientLogoUrl { get; set; } = default!;
    public string Description { get; set; } = default!;
    public DateTime Created { get; set; }
    public DateTime? Expires { get; set; }
    public IEnumerable<string> IdentityGrantNames { get; set; } = default!;
    public IEnumerable<string> ApiGrantNames { get; set; } = default!;
}