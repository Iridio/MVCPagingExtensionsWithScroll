using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using PagingExtensionsWithScroll.Helpers;

namespace PagingExtensionsWithScroll.Tests.Helpers
{
  [TestFixture]
  class PageLinksTests
  {
    [Test]
    public void PageLinks_ScrollList5_FirstHalfSelected_ReturnsFirst5Links()
    {
      HtmlHelper html = null;
      MvcHtmlString result = html.PageLinks(10, 1, 2, "active", 5, x => string.Format("/base/{0}", x));
      Assert.IsInstanceOf(typeof(MvcHtmlString), result);
      Assert.AreEqual("<ul>\r\n<li><a href=\"/base/1\">1</a></li>\r\n<li class=\"active\"><a href=\"/base/2\">2</a></li>\r\n<li><a href=\"/base/3\">3</a></li>\r\n<li><a href=\"/base/4\">4</a></li>\r\n<li><a href=\"/base/5\">5</a></li>\r\n</ul>\r\n", result.ToString());
    }

    [Test]
    public void PageLinks_ScrollList5_MiddleSelected_ReturnsFirst5Links()
    {
      HtmlHelper html = null;
      MvcHtmlString result = html.PageLinks(10, 1, 3, "active", 5, x => string.Format("/base/{0}", x));
      Assert.IsInstanceOf(typeof(MvcHtmlString), result);
      Assert.AreEqual("<ul>\r\n<li><a href=\"/base/1\">1</a></li>\r\n<li><a href=\"/base/2\">2</a></li>\r\n<li class=\"active\"><a href=\"/base/3\">3</a></li>\r\n<li><a href=\"/base/4\">4</a></li>\r\n<li><a href=\"/base/5\">5</a></li>\r\n</ul>\r\n", result.ToString());
    }

    [Test]
    public void PageLinks_ScrollList5_SecondHalfSelected_ReturnsShiftedLinks()
    {
      HtmlHelper html = null;
      MvcHtmlString result = html.PageLinks(10, 1, 4, "active", 5, x => string.Format("/base/{0}", x));
      Assert.IsInstanceOf(typeof(MvcHtmlString), result);
      Assert.AreEqual("<ul>\r\n<li><a href=\"/base/2\">2</a></li>\r\n<li><a href=\"/base/3\">3</a></li>\r\n<li class=\"active\"><a href=\"/base/4\">4</a></li>\r\n<li><a href=\"/base/5\">5</a></li>\r\n<li><a href=\"/base/6\">6</a></li>\r\n</ul>\r\n", result.ToString());
    }

    [Test]
    public void PageLinks_ScrollList10_FirstHalfSelected_ReturnsFirst10Links()
    {
      HtmlHelper html = null;
      MvcHtmlString result = html.PageLinks(20, 1, 5, "active", 10, x => string.Format("/base/{0}", x));
      Assert.IsInstanceOf(typeof(MvcHtmlString), result);
      Assert.AreEqual("<ul>\r\n<li><a href=\"/base/1\">1</a></li>\r\n<li><a href=\"/base/2\">2</a></li>\r\n<li><a href=\"/base/3\">3</a></li>\r\n<li><a href=\"/base/4\">4</a></li>\r\n<li class=\"active\"><a href=\"/base/5\">5</a></li>\r\n<li><a href=\"/base/6\">6</a></li>\r\n<li><a href=\"/base/7\">7</a></li>\r\n<li><a href=\"/base/8\">8</a></li>\r\n<li><a href=\"/base/9\">9</a></li>\r\n<li><a href=\"/base/10\">10</a></li>\r\n</ul>\r\n", result.ToString());
    }

    [Test]
    public void PageLinks_ScrollList10_SecondHalfSelected_ReturnsShiftedLinks()
    {
      HtmlHelper html = null;
      MvcHtmlString result = html.PageLinks(20, 1, 6, "active", 10, x => string.Format("/base/{0}", x));
      Assert.IsInstanceOf(typeof(MvcHtmlString), result);
      Assert.AreEqual("<ul>\r\n<li><a href=\"/base/2\">2</a></li>\r\n<li><a href=\"/base/3\">3</a></li>\r\n<li><a href=\"/base/4\">4</a></li>\r\n<li><a href=\"/base/5\">5</a></li>\r\n<li class=\"active\"><a href=\"/base/6\">6</a></li>\r\n<li><a href=\"/base/7\">7</a></li>\r\n<li><a href=\"/base/8\">8</a></li>\r\n<li><a href=\"/base/9\">9</a></li>\r\n<li><a href=\"/base/10\">10</a></li>\r\n<li><a href=\"/base/11\">11</a></li>\r\n</ul>\r\n", result.ToString());
    }

    [Test]
    public void PageLinks_ScrollList10_Page15_FirstHalfSelected_ReturnsFirst10Links()
    {
      HtmlHelper html = null;
      MvcHtmlString result = html.PageLinks(50, 1, 15, "active", 10, x => string.Format("/base/{0}", x));
      Assert.IsInstanceOf(typeof(MvcHtmlString), result);
      Assert.AreEqual("<ul>\r\n<li><a href=\"/base/11\">11</a></li>\r\n<li><a href=\"/base/12\">12</a></li>\r\n<li><a href=\"/base/13\">13</a></li>\r\n<li><a href=\"/base/14\">14</a></li>\r\n<li class=\"active\"><a href=\"/base/15\">15</a></li>\r\n<li><a href=\"/base/16\">16</a></li>\r\n<li><a href=\"/base/17\">17</a></li>\r\n<li><a href=\"/base/18\">18</a></li>\r\n<li><a href=\"/base/19\">19</a></li>\r\n<li><a href=\"/base/20\">20</a></li>\r\n</ul>\r\n", result.ToString());
    }

    [Test]
    public void PageLinks_ScrollList10_Page18_SecondHalfSelected_ReturnsShiftedLinks()
    {
      HtmlHelper html = null;
      MvcHtmlString result = html.PageLinks(50, 1, 18, "active", 10, x => string.Format("/base/{0}", x));
      Assert.IsInstanceOf(typeof(MvcHtmlString), result);
      Assert.AreEqual("<ul>\r\n<li><a href=\"/base/14\">14</a></li>\r\n<li><a href=\"/base/15\">15</a></li>\r\n<li><a href=\"/base/16\">16</a></li>\r\n<li><a href=\"/base/17\">17</a></li>\r\n<li class=\"active\"><a href=\"/base/18\">18</a></li>\r\n<li><a href=\"/base/19\">19</a></li>\r\n<li><a href=\"/base/20\">20</a></li>\r\n<li><a href=\"/base/21\">21</a></li>\r\n<li><a href=\"/base/22\">22</a></li>\r\n<li><a href=\"/base/23\">23</a></li>\r\n</ul>\r\n", result.ToString());
    }

    [Test]
    public void PageLinks_ScrollList10_Page18_LastLinksShowed()
    {
      HtmlHelper html = null;
      MvcHtmlString result = html.PageLinks(20, 1, 18, "active", 10, x => string.Format("/base/{0}", x));
      Assert.IsInstanceOf(typeof(MvcHtmlString), result);
      Assert.AreEqual("<ul>\r\n<li><a href=\"/base/11\">11</a></li>\r\n<li><a href=\"/base/12\">12</a></li>\r\n<li><a href=\"/base/13\">13</a></li>\r\n<li><a href=\"/base/14\">14</a></li>\r\n<li><a href=\"/base/15\">15</a></li>\r\n<li><a href=\"/base/16\">16</a></li>\r\n<li><a href=\"/base/17\">17</a></li>\r\n<li class=\"active\"><a href=\"/base/18\">18</a></li>\r\n<li><a href=\"/base/19\">19</a></li>\r\n<li><a href=\"/base/20\">20</a></li>\r\n</ul>\r\n", result.ToString());
    }

    [Test]
    public void PageLinks_ScrollList10_NoPages_ReturnsEmptyString()
    {
      HtmlHelper html = null;
      MvcHtmlString result = html.PageLinks(0, 1, 0, "active", 10, x => string.Format("/base/{0}", x));
      Assert.IsInstanceOf(typeof(MvcHtmlString), result);
      Assert.AreEqual("", result.ToString());
    }

    [Test]
    public void PageLinks_ScrollList10_OnePages_ReturnsList()
    {
      HtmlHelper html = null;
      MvcHtmlString result = html.PageLinks(1, 5, 0, "active", 10, x => string.Format("/base/{0}", x));
      Assert.IsInstanceOf(typeof(MvcHtmlString), result);
      Assert.AreEqual("<ul>\r\n<li class=\"active\"><a href=\"/base/1\">1</a></li>\r\n</ul>\r\n", result.ToString());
    }
  }
}
