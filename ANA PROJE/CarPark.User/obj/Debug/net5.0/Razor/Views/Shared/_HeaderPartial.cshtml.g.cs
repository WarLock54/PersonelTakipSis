#pragma checksum "C:\Users\onr_5\Desktop\ANA PROJE\CarPark.User\Views\Shared\_HeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "797399f38d56c1167207d63b8b853dc1e0e31a8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderPartial), @"mvc.1.0.view", @"/Views/Shared/_HeaderPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\onr_5\Desktop\ANA PROJE\CarPark.User\Views\_ViewImports.cshtml"
using CarPark.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\onr_5\Desktop\ANA PROJE\CarPark.User\Views\_ViewImports.cshtml"
using CarPark.User.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\onr_5\Desktop\ANA PROJE\CarPark.User\Views\_ViewImports.cshtml"
using CarPark.Models.RequestModel.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\onr_5\Desktop\ANA PROJE\CarPark.User\Views\_ViewImports.cshtml"
using CarPark.Models.ViewModels.Personels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\onr_5\Desktop\ANA PROJE\CarPark.User\Views\Shared\_HeaderPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"797399f38d56c1167207d63b8b853dc1e0e31a8e", @"/Views/Shared/_HeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2a727c31df83220ca8f85ebc79e9bd8b7cf8474", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__HeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral(@"

<header class=""topbar"">
    <div class=""topbar-left"">
        <span class=""topbar-btn sidebar-toggler""><i>&#9776;</i></span>

        <a class=""topbar-btn d-none d-md-block"" href=""#"" data-provide=""fullscreen tooltip"" title=""Fullscreen"">
            <i class=""material-icons fullscreen-default"">fullscreen</i>
            <i class=""material-icons fullscreen-active"">fullscreen_exit</i>
        </a>

        <div class=""dropdown d-none d-md-block"">
            <span class=""topbar-btn"" data-toggle=""dropdown""><i class=""ti-layout-grid3-alt""></i></span>
            <div class=""dropdown-menu dropdown-grid"">
                <a class=""dropdown-item"" href=""../dashboard/general.html"">
                    <span data-i8-icon=""home""></span>
                    <span class=""title"">Dashboard</span>
                </a>
                <a class=""dropdown-item"" href=""../page/gallery.html"">
                    <span data-i8-icon=""stack_of_photos""></span>
                    <span class=""title"">Gallery</span>
                </a>");
            WriteLiteral(@"
                <a class=""dropdown-item"" href=""../page/search.html"">
                    <span data-i8-icon=""search""></span>
                    <span class=""title"">Search</span>
                </a>
                <a class=""dropdown-item"" href=""../page-app/calendar.html"">
                    <span data-i8-icon=""calendar""></span>
                    <span class=""title"">Calendar</span>
                </a>
                <a class=""dropdown-item"" href=""../page-app/chat.html"">
                    <span data-i8-icon=""sms""></span>
                    <span class=""title"">Chat</span>
                </a>
                <a class=""dropdown-item"" href=""../page-app/mailbox.html"">
                    <span data-i8-icon=""invite""></span>
                    <span class=""title"">Emails</span>
                </a>
                <a class=""dropdown-item"" href=""../page-app/users.html"">
                    <span data-i8-icon=""contacts""></span>
                    <span class=""title"">Contacts</span>
                </a>
    ");
            WriteLiteral(@"            <a class=""dropdown-item"" href=""../widget/chart.html"">
                    <span data-i8-icon=""bar_chart""></span>
                    <span class=""title"">Charts</span>
                </a>
                <a class=""dropdown-item"" href=""../page/profile.html"">
                    <span data-i8-icon=""businessman""></span>
                    <span class=""title"">Profile</span>
                </a>
            </div>
        </div>

        <div class=""topbar-divider d-none d-md-block""></div>

        <div class=""lookup d-none d-md-block topbar-search"" id=""theadmin-search"">
            <input class=""form-control w-300px"" type=""text"">
            <div class=""lookup-placeholder"">
                <i class=""ti-search""></i>
                <span data-provide=""typing"" data-type=""<strong>Type</strong> Button|<strong>Type</strong> Slider|<strong>Type</strong> Layout|<strong>Type</strong> Modal|<strong>Try</strong> typing any keyword..."" data-loop=""false"" data-type-speed=""90"" data-back-speed=""50"" data-show-cursor");
            WriteLiteral(@"=""false""></span>
            </div>
        </div>
    </div>

    <div class=""topbar-right"">
        <a class=""topbar-btn"" href=""#qv-global"" data-toggle=""quickview""><i class=""ti-align-right""></i></a>

        <div class=""topbar-divider""></div>

        <ul class=""topbar-btns"">
            <li class=""dropdown"">
                <span class=""topbar-btn"" data-toggle=""dropdown""><img class=""avatar"" src=""../assets/img/avatar/1.jpg"" alt=""...""></span>
                <div class=""dropdown-menu dropdown-menu-right"">
");
#nullable restore
#line 78 "C:\Users\onr_5\Desktop\ANA PROJE\CarPark.User\Views\Shared\_HeaderPartial.cshtml"
                     if (SignInManager.IsSignedIn(User))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"dropdown-item\" href=\"/Personels/Settings\"><i class=\"ti-settings\"></i> ");
#nullable restore
#line 80 "C:\Users\onr_5\Desktop\ANA PROJE\CarPark.User\Views\Shared\_HeaderPartial.cshtml"
                                                                                                   Write(UserManager.GetUserName(User));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                        <div class=\"dropdown-divider\"></div>\n                        <a class=\"dropdown-item\" href=\"/Account/LogOut\"><i class=\"ti-power-off\"></i> Çıkış Yap</a>\n");
#nullable restore
#line 83 "C:\Users\onr_5\Desktop\ANA PROJE\CarPark.User\Views\Shared\_HeaderPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"dropdown-item\" href=\"/Account/Login\"><i class=\"ti-power-off\"></i> Giriş Yap</a>\n");
#nullable restore
#line 87 "C:\Users\onr_5\Desktop\ANA PROJE\CarPark.User\Views\Shared\_HeaderPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </li>

            <!-- Notifications -->
            <li class=""dropdown d-none d-md-block"">
                <span class=""topbar-btn has-new"" data-toggle=""dropdown""><i class=""ti-bell""></i></span>
                <div class=""dropdown-menu dropdown-menu-right"">

                    <div class=""media-list media-list-hover media-list-divided media-list-xs"">
                        <a class=""media media-new"" href=""#"">
                            <span class=""avatar bg-success""><i class=""ti-user""></i></span>
                            <div class=""media-body"">
                                <p>New user registered</p>
                                <time datetime=""2018-07-14 20:00"">Just now</time>
                            </div>
                        </a>

                        <a class=""media"" href=""#"">
                            <span class=""avatar bg-info""><i class=""ti-shopping-cart""></i></span>
                            <div class=""media-body"">
                   ");
            WriteLiteral(@"             <p>New order received</p>
                                <time datetime=""2018-07-14 20:00"">2 min ago</time>
                            </div>
                        </a>

                        <a class=""media"" href=""#"">
                            <span class=""avatar bg-warning""><i class=""ti-face-sad""></i></span>
                            <div class=""media-body"">
                                <p>Refund request from <b>Ashlyn Culotta</b></p>
                                <time datetime=""2018-07-14 20:00"">24 min ago</time>
                            </div>
                        </a>

                        <a class=""media"" href=""#"">
                            <span class=""avatar bg-primary""><i class=""ti-money""></i></span>
                            <div class=""media-body"">
                                <p>New payment has made through PayPal</p>
                                <time datetime=""2018-07-14 20:00"">53 min ago</time>
                            </div>
                  ");
            WriteLiteral(@"      </a>
                    </div>

                    <div class=""dropdown-footer"">
                        <div class=""left"">
                            <a href=""#"">Read all notifications</a>
                        </div>

                        <div class=""right"">
                            <a href=""#"" data-provide=""tooltip"" title=""Mark all as read""><i class=""fa fa-circle-o""></i></a>
                            <a href=""#"" data-provide=""tooltip"" title=""Update""><i class=""fa fa-repeat""></i></a>
                            <a href=""#"" data-provide=""tooltip"" title=""Settings""><i class=""fa fa-gear""></i></a>
                        </div>
                    </div>

                </div>
            </li>
            <!-- END Notifications -->
            <!-- Messages -->
            <li class=""dropdown d-none d-md-block"">
                <span class=""topbar-btn"" data-toggle=""dropdown""><i class=""ti-email""></i></span>
                <div class=""dropdown-menu dropdown-menu-right"">

                    <d");
            WriteLiteral(@"iv class=""media-list media-list-divided media-list-hover media-list-xs scrollable"" style=""height: 290px"">
                        <a class=""media media-new1"" href=""page-app/mailbox-single.html"">
                            <span class=""avatar status-success"">
                                <img src=""../assets/img/avatar/1.jpg"" alt=""..."">
                            </span>

                            <div class=""media-body"">
                                <p><strong>Maryam Amiri</strong> <time class=""float-right"" datetime=""2018-07-14 20:00"">23 min ago</time></p>
                                <p class=""text-truncate"">Authoritatively exploit resource maximizing technologies before technically.</p>
                            </div>
                        </a>

                        <a class=""media media-new1"" href=""page-app/mailbox-single.html"">
                            <span class=""avatar status-warning"">
                                <img src=""../assets/img/avatar/2.jpg"" alt=""..."">
              ");
            WriteLiteral(@"              </span>

                            <div class=""media-body"">
                                <p><strong>Hossein Shams</strong> <time class=""float-right"" datetime=""2018-07-14 20:00"">48 min ago</time></p>
                                <p class=""text-truncate"">Continually plagiarize efficient interfaces after bricks-and-clicks niches.</p>
                            </div>
                        </a>

                        <a class=""media"" href=""page-app/mailbox-single.html"">
                            <span class=""avatar status-dark"">
                                <img src=""../assets/img/avatar/3.jpg"" alt=""..."">
                            </span>

                            <div class=""media-body"">
                                <p><strong>Helen Bennett</strong> <time class=""float-right"" datetime=""2018-07-14 20:00"">3 hours ago</time></p>
                                <p class=""text-truncate"">Objectively underwhelm cross-unit web-readiness before sticky outsourcing.</p>
              ");
            WriteLiteral(@"              </div>
                        </a>

                        <a class=""media"" href=""page-app/mailbox-single.html"">
                            <span class=""avatar status-success bg-purple"">FT</span>

                            <div class=""media-body"">
                                <p><strong>Fidel Tonn</strong> <time class=""float-right"" datetime=""2018-07-14 20:00"">21 hours ago</time></p>
                                <p class=""text-truncate"">Interactively innovate transparent relationships with holistic infrastructures.</p>
                            </div>
                        </a>

                        <a class=""media"" href=""page-app/mailbox-single.html"">
                            <span class=""avatar status-danger"">
                                <img src=""../assets/img/avatar/4.jpg"" alt=""..."">
                            </span>

                            <div class=""media-body"">
                                <p><strong>Freddie Arends</strong> <time class=""float-right"" date");
            WriteLiteral(@"time=""2018-07-14 20:00"">Yesterday</time></p>
                                <p class=""text-truncate"">Collaboratively visualize corporate initiatives for web-enabled value.</p>
                            </div>
                        </a>

                        <a class=""media"" href=""page-app/mailbox-single.html"">
                            <span class=""avatar status-success"">
                                <img src=""../assets/img/avatar/5.jpg"" alt=""..."">
                            </span>

                            <div class=""media-body"">
                                <p><strong>Freddie Arends</strong> <time class=""float-right"" datetime=""2018-07-14 20:00"">Yesterday</time></p>
                                <p class=""text-truncate"">Interactively reinvent standards compliant supply chains through next-generation bandwidth.</p>
                            </div>
                        </a>
                    </div>

                    <div class=""dropdown-footer"">
                        <div cl");
            WriteLiteral(@"ass=""left"">
                            <a href=""#"">Read all messages</a>
                        </div>

                        <div class=""right"">
                            <a href=""#"" data-provide=""tooltip"" title=""Mark all as read""><i class=""fa fa-circle-o""></i></a>
                            <a href=""#"" data-provide=""tooltip"" title=""Settings""><i class=""fa fa-gear""></i></a>
                        </div>
                    </div>

                </div>
            </li>
            <!-- END Messages -->

        </ul>

        <div class=""topbar-divider""></div>


    </div>
</header>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<CarPark.Entities.concrete.Personel> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<CarPark.Entities.concrete.Personel> SignInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
