#pragma checksum "D:\visual\WebSite\WebSite\Views\Shared\_MyLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01dcd9490b9e39a6882102a02eda8e9e631d484f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MyLayout), @"mvc.1.0.view", @"/Views/Shared/_MyLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_MyLayout.cshtml", typeof(AspNetCore.Views_Shared__MyLayout))]
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
#line 1 "D:\visual\WebSite\WebSite\Views\_ViewImports.cshtml"
using WebSite;

#line default
#line hidden
#line 2 "D:\visual\WebSite\WebSite\Views\_ViewImports.cshtml"
using WebSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01dcd9490b9e39a6882102a02eda8e9e631d484f", @"/Views/Shared/_MyLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9751a11891ba42cf18e84a4b82e03210f652818", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MyLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 716, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f82f75a75c6c41868b053c326faaeac1", async() => {
                BeginContext(33, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(106, 13, false);
#line 6 "D:\visual\WebSite\WebSite\Views\Shared\_MyLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(119, 617, true);
                WriteLiteral(@"</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta http-equiv=""x-ua-compatible"" content=""ie=edge"">
    <title>Ayberk KÖSE</title>
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.8.2/css/all.css"">
    <!-- Bootstrap core CSS -->
    <link href=""css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- Material Design Bootstrap -->
    <link href=""css/mdb.min.css"" rel=""stylesheet"">
    <!-- Your custom styles (optional) -->
    <link href=""css/style.css"" rel=""stylesheet"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(743, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(745, 16324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97a2777add3049b98aa8519aa949a44a", async() => {
                BeginContext(751, 14892, true);
                WriteLiteral(@"
    <div>

        <!-- Start your project here-->
        <header>
            <!--Navbar-->
            <nav class=""navbar navbar-expand-lg navbar-dark fixed-top scrolling-navbar"">
                <div class=""container"">
                    <a class=""navbar-brand"" href=""#""><strong><img src=""img/logom.png"" height=""80px""></strong></a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent-7""
                            aria-controls=""navbarSupportedContent-7"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent-7"">
                        <ul class=""navbar-nav ml-auto"">
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#""><b>Anasayfa</b><span class=""sr-only"">(current)</span></a>
        ");
                WriteLiteral(@"                    </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""iletisim.html""><b>İletişim</b></a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
            <!-- Navbar -->
            <!-- Full Page Intro -->
            <div class=""view jarallax"" data-jarallax='{""speed"": 0.2}' style=""background-image: url('https://mdbootstrap.com/img/Photos/Horizontal/Nature/full page/img(20).jpg'); background-repeat: no-repeat; background-size: cover; background-position: center center;"">
                <!-- Mask & flexbox options-->
                <div class=""mask rgba-black-light d-flex justify-content-center align-items-center"">
                    <!-- Content -->
                    <div class=""container"">
                        <!--Grid row-->
                        <div class=""row"">
                            <!--Grid column-->
           ");
                WriteLiteral(@"                 <div class=""col-md-12 mb-4 white-text text-center"">
                                <h1 style=""font-family:impact"" class=""h1-reponsive white-text text-uppercase font-weight-bold mb-0 pt-md-5 pt-5 wow fadeInDown""
                                    data-wow-delay=""0.3s"">
                                    <strong>AYBERK KÖSE</strong>
                                </h1>
                                <hr class=""hr-light my-4 wow fadeInDown"" data-wow-delay=""0.4s"">
                                <h4 style=""font-family:impact"" class=""text-uppercase mb-4 white-text wow fadeInDown"" data-wow-delay=""0.4s"">
                                    <strong>
                                        Bilgisayar Mühendisi
                                    </strong>
                                </h4>
                                <a class=""btn btn-outline-white wow fadeInDown"" data-wow-delay=""0.4s"" href=""#hakkimda"">Hakkımda</a>
                                <a class=""btn btn-outline-white");
                WriteLiteral(@" wow fadeInDown"" data-wow-delay=""0.4s"" href=""#yazilarim"">Yazılarım</a>
                            </div>
                            <!--Grid column-->
                        </div>
                        <!--Grid row-->
                    </div>
                    <!-- Content -->
                </div>
                <!-- Mask & flexbox options-->
            </div>
            <!-- Full Page Intro -->
        </header>
        <!-- Start your project here-->
        <!-- Section: Features v.4 -->
        <div class=""container"" id=""hakkimda"">
            <section class=""my-5"">
                <!-- Section heading -->
                <h2 class=""h1-responsive font-weight-bold text-center my-5"">HAKKIMDA</h2>
                <!-- Section description -->
                <!-- Grid row -->
                <div class=""row"">
                    <!-- Grid column -->
                    <div class=""col-md-4"">
                        <!-- Grid row -->
                        <div class=""ro");
                WriteLiteral(@"w mb-9"">
                            <!-- Grid column -->
                            <div class=""col-2"">

                            </div>
                            <!-- Grid column -->
                            <!-- Grid column -->
                            <div class=""col-10"">
                                <h5 class=""font-weight-bold mb-3"" style=""text-align:center"">Kişisel Bilgilerim</h5>
                                <p class=""grey-text"">
                                    <strong>
                                        <b>-Ad:</b> Ayberk
                                        <br>
                                        <b>-Soyad:</b> Köse
                                        <br>
                                        <b>-Yaş:</b> 18
                                        <br>
                                        <b>-Okul:</b> Sakarya Üniversitesi
                                        <br>
                                        <b>-Bölüm:</b> Bilgisayar Mühen");
                WriteLiteral(@"disliği
                                        <br>
                                        <b>-Cep Telefonu:</b> +90 531 978 36 18
                                        <br>
                                        <b>-E-Mail:</b> ayberkkose54@hotmail.com
                                        <br>
                                        <b>-Dil Bilgisi:</b> Türkçe,İngilizce,Almanca
                                        <br>
                                        <b>-Yaşadığım İl:</b> Sakarya
                                        <br>
                                        <b>-Medeni Durum:</b> Bekar
                                        <br>
                                        <b>-İş Deneyimi:</b> Matematik Özel Ders
                                        <br>
                                        <b>-Mevcut İş:</b> Matematik Özel Ders
                                        <br>
                                        <b>-İlgi Alanlarım:</b> Programlama, Web Tasarım, Balık");
                WriteLiteral(@"çılık, Oyunlar, Kitaplar

                                    </strong>
                                </p>
                            </div>
                            <!-- Grid column -->

                        </div>
                        <!-- Grid row -->
                    </div>
                    <!-- Grid column -->
                    <!-- Grid column -->
                    <div class=""col-md-4 text-center"">
                        <div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
                            <div class=""carousel-inner"">
                                <div class=""carousel-item active"">
                                    <img class=""d-block w-100"" src=""img/pp.jpg""
                                         alt=""First slide"">
                                </div>
                                <div class=""carousel-item"">
                                    <img class=""d-block w-100"" src=""img/pp1.jpg""
                         ");
                WriteLiteral(@"                alt=""Second slide"">
                                </div>
                                <div class=""carousel-item"">
                                    <img class=""d-block w-100"" src=""img/pp2.jpg""
                                         alt=""Third slide"">
                                </div>
                            </div>
                            <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                <span class=""sr-only"">Previous</span>
                            </a>
                            <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                                <span class=""sr-only"">Next</span>
                            </a>
     ");
                WriteLiteral(@"                   </div>
                    </div>
                    <!-- Grid column -->
                    <!-- Grid column -->
                    <div class=""col-md-4"">
                        <!-- Grid row -->
                        <div class=""row mb-9"">
                            <!-- Grid column -->
                            <div class=""col-2"">

                            </div>
                            <!-- Grid column -->
                            <!-- Grid column -->
                            <div class=""col-10"" style=""text-align:justify"">
                                <h5 class=""font-weight-bold mb-3"" style=""text-align:center"">Kısaca Ben</h5>
                                <p class=""grey-text"">
                                    2000 yılında Sakarya'da doğdum. İlkokul eğitimimi Şehit Mustafa Özen İlkokulu'nda,
                                    ortaokul eğitimimi Nuri Bayar Ortaokulu'nda, lise eğitimimi ise Sakarya Anadolu Lisesi'nde tamamladım.
            ");
                WriteLiteral(@"                        Şu anda ise eğitimimi Sakarya Üniversitesi Bilgisayar Mühendisliği Bölümü'nde devam ettirmekteyim. 2 çocuklu
                                    bir ailenin küçük çocuğuyum.
                                </p>
                            </div>
                            <!-- Grid column -->
                        </div>

                    </div>
                    <!-- Grid column -->
                </div>
                <!-- Grid row -->
            </section>
            <!-- Section: Features v.4 -->
        </div>
        <div class=""container"" id=""yazilarim"">
            <h2 class=""h1-responsive font-weight-bold text-center my-5"">YAZILARIM</h2>
            <div class=""row"">
                <!-- Card -->
                <div class=""col-md-4 col-sm-12 text-center"">
                    <div class=""card"">
                        <!-- Card image -->
                        <img class=""card-img-top"" src=""img/coding.png"" alt=""Card image cap"">
              ");
                WriteLiteral(@"          <!-- Card content -->
                        <div class=""card-body"">
                            <!-- Title -->
                            <h4 class=""card-title""><a>YAZI1</a></h4>
                            <!-- Text -->
                            <p class=""card-text"">İlk Makalem...</p>
                            <!-- Button -->
                            <a href=""#"" class=""btn btn-primary"">OKU</a>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 col-sm-12 text-center"">
                    <div class=""card"">
                        <!-- Card image -->
                        <img class=""card-img-top"" src=""img/cook.jpg"" alt=""Card image cap"">
                        <!-- Card content -->
                        <div class=""card-body"">
                            <!-- Title -->
                            <h4 class=""card-title""><a>YAZI2</a></h4>
                            <!-- Text -->
                      ");
                WriteLiteral(@"      <p class=""card-text"">İkinci Makalem...</p>
                            <!-- Button -->
                            <a href=""#"" class=""btn btn-primary"">OKU</a>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 col-sm-12 text-center"">
                    <div class=""card"">
                        <!-- Card image -->
                        <img class=""card-img-top"" src=""img/acarlar.jpg"" alt=""Card image cap"">
                        <!-- Card content -->
                        <div class=""card-body"">
                            <!-- Title -->
                            <h4 class=""card-title""><a>YAZI3</a></h4>
                            <!-- Text -->
                            <p class=""card-text"">Üçüncü Makalem...</p>
                            <!-- Button -->
                            <a href=""#"" class=""btn btn-primary"">OKU</a>
                        </div>
                    </div>
                </div>
   ");
                WriteLiteral(@"         </div>
            <!-- Card -->
        </div>
        <!-- Footer -->
        <div>
            <footer class=""page-footer font-small cyan darken-3"">
                <!-- Footer Elements -->
                <div class=""container"">
                    <!-- Grid row-->
                    <div class=""row"" style=""text-align:center;"">
                        <div class=""col-md-2"">
                        </div>
                        <div class=""col-md-8"">
                            <h5><b><i>Bana Ulaşın</i></b></h5>
                        </div>
                        <div class=""col-md-2"">
                        </div>
                    </div>
                    <div class=""row"">
                        <!-- Grid column -->
                        <div class=""col-md-12 py-5"">
                            <div class=""mb-5 flex-center"">
                                <!-- Facebook -->
                                <a class=""fb-ic"" target=""_blank"" href=""https://www.faceb");
                WriteLiteral(@"ook.com/ayberk.kose.39"">
                                    <i class=""fab fa-facebook-f fa-lg white-text mr-md-5 mr-3 fa-2x""> </i>
                                </a>
                                <!-- Twitter -->
                                <a class=""tw-ic"" target=""_blank"" href=""https://twitter.com/MrAlbino_"">
                                    <i class=""fab fa-twitter fa-lg white-text mr-md-5 mr-3 fa-2x""> </i>
                                </a>
                                <!--Linkedin -->
                                <a class=""li-ic"" target=""_blank"" name=""footer"" href=""https://www.linkedin.com/in/ayberk-k%C3%B6se-2ab70b169/"">
                                    <i class=""fab fa-linkedin-in fa-lg white-text mr-md-5 mr-3 fa-2x""> </i>
                                </a>

                                <!--Instagram-->
                                <a class=""ins-ic"" target=""_blank"" href=""https://www.instagram.com/ayberk_kose/"">
                                    <i class=""fa");
                WriteLiteral(@"b fa-instagram fa-lg white-text mr-md-5 mr-3 fa-2x""> </i>
                                </a>
                                <!--Youtube-->
                                <a class=""pin-ic"" target=""_blank"" href=""https://www.youtube.com/channel/UCOZU-NslgW24aEDkpZtreag?view_as=subscriber"">
                                    <i class=""fab fa-youtube fa-lg white-text mr-md-5 mr-3 fa-2x""> </i>
                                </a>
                                <!--Google-Maps-->
                                <a class=""pin-ic"" target=""_blank""");
                EndContext();
                BeginWriteAttribute("href", " href=", 15643, "", 15858, 1);
#line 287 "D:\visual\WebSite\WebSite\Views\Shared\_MyLayout.cshtml"
WriteAttributeValue("", 15649, "https://www.google.com/maps/place/Sakarya+%C3%9Cniversitesi/@40.7414918,30.3219558,15z/data=!4m8!1m2!2m1!1ssakarya+%C3%BCniversitesi!3m4!1s0x14ccadf2977958d7:0xc7996fa884f94c03!8m2!3d40.742033!4d30.332731", 15649, 209, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(15858, 1177, true);
                WriteLiteral(@">
                                    <i class=""fas fa-map-marker-alt fa-lg white-text fa-2x""></i>
                                </a>

                            </div>

                        </div>
                        <!-- Grid column -->
                    </div>
                    <!-- Grid row-->
                </div>
                <!-- Footer Elements -->
                <!-- Copyright -->
                <div class=""footer-copyright text-center py-3"">
                    © 2019 Copyright:
                    <a href="""">Ayberk KÖSE</a>
                </div>
                <!-- Copyright -->
            </footer>
        </div>
        <!-- Footer -->
        <!-- SCRIPTS -->
        <!-- JQuery -->
        <script type=""text/javascript"" src=""js/jquery-3.4.1.min.js""></script>
        <!-- Bootstrap tooltips -->
        <script type=""text/javascript"" src=""js/popper.min.js""></script>
        <!-- Bootstrap core JavaScript -->
        <script type=""text/javascript"" ");
                WriteLiteral("src=\"js/bootstrap.min.js\"></script>\r\n        <!-- MDB core JavaScript -->\r\n        <script type=\"text/javascript\" src=\"js/mdb.min.js\"></script>\r\n        ");
                EndContext();
                BeginContext(17036, 12, false);
#line 317 "D:\visual\WebSite\WebSite\Views\Shared\_MyLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(17048, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(17069, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
