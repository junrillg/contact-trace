#pragma checksum "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9944e7892e38572ccc92c5162ddb9271d71cbfa2"
// <auto-generated/>
#pragma warning disable 1591
namespace ContactTrace.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Personal\ContactTrace\ContactTrace.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Personal\ContactTrace\ContactTrace.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Personal\ContactTrace\ContactTrace.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Personal\ContactTrace\ContactTrace.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Personal\ContactTrace\ContactTrace.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Personal\ContactTrace\ContactTrace.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Personal\ContactTrace\ContactTrace.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Personal\ContactTrace\ContactTrace.Client\_Imports.razor"
using ContactTrace.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Personal\ContactTrace\ContactTrace.Client\_Imports.razor"
using ContactTrace.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
using DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
using Data.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contact")]
    public partial class Contact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Contact</h1>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-info");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
                                       OnToggleCreateForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Create New");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 11 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
 if (displayCreateForm)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
                      newContact

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
                                                  InsertContact

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    \r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "firstName");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
                                               newContact.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newContact.FirstName = __value, newContact.FirstName))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newContact.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "lastName");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
                                              newContact.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newContact.LastName = __value, newContact.LastName))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newContact.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "id", "address");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
                                             newContact.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newContact.Address = __value, newContact.Address))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newContact.Address));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.AddMarkupContent(34, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n        ");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "type", "submit");
                __builder2.AddAttribute(37, "class", "btn btn-danger");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
                                                               OnToggleCreateForm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(39, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 23 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "\r\n");
            __builder.AddMarkupContent(43, "<h4>Current Contact</h4>\r\n\r\n");
#nullable restore
#line 27 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
 if (contact is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "    ");
            __builder.AddMarkupContent(45, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 30 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "    ");
            __builder.OpenElement(47, "table");
            __builder.AddAttribute(48, "class", "table");
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.AddMarkupContent(50, "<thead>\r\n        <tr>\r\n            <th scope=\"col\">First</th>\r\n            <th scope=\"col\">Last</th>\r\n            <th scope=\"col\">Address</th>\r\n        </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(51, "tbody");
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 42 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
         foreach (var person in contact)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "            ");
            __builder.OpenElement(54, "tr");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 45 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
                     person.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 46 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
                     person.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 47 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
                     person.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 49 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 52 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\Personal\ContactTrace\ContactTrace.Client\Pages\Contact.razor"
       
    private List<ContactModel> contact;
    private ContactViewModel newContact = new ContactViewModel();
    private bool displayCreateForm = false;

    protected override async Task OnInitializedAsync()
    {
        contact = await _db.GetContact();
    }

    private async Task InsertContact()
    {
        var model = new ContactModel
        {
            FirstName = newContact.FirstName,
            LastName = newContact.LastName,
            Address = newContact.Address
        };
        await _db.InsertContact(model);
        contact.Add(model);
        newContact = new ContactViewModel();
    }

    private void OnToggleCreateForm()
    {
        displayCreateForm = !displayCreateForm;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContactData _db { get; set; }
    }
}
#pragma warning restore 1591
