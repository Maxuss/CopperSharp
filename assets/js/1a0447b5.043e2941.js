"use strict";(self.webpackChunkdocs=self.webpackChunkdocs||[]).push([[16637],{3905:function(e,t,r){r.d(t,{Zo:function(){return d},kt:function(){return g}});var a=r(67294);function n(e,t,r){return t in e?Object.defineProperty(e,t,{value:r,enumerable:!0,configurable:!0,writable:!0}):e[t]=r,e}function i(e,t){var r=Object.keys(e);if(Object.getOwnPropertySymbols){var a=Object.getOwnPropertySymbols(e);t&&(a=a.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),r.push.apply(r,a)}return r}function p(e){for(var t=1;t<arguments.length;t++){var r=null!=arguments[t]?arguments[t]:{};t%2?i(Object(r),!0).forEach((function(t){n(e,t,r[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(r)):i(Object(r)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(r,t))}))}return e}function l(e,t){if(null==e)return{};var r,a,n=function(e,t){if(null==e)return{};var r,a,n={},i=Object.keys(e);for(a=0;a<i.length;a++)r=i[a],t.indexOf(r)>=0||(n[r]=e[r]);return n}(e,t);if(Object.getOwnPropertySymbols){var i=Object.getOwnPropertySymbols(e);for(a=0;a<i.length;a++)r=i[a],t.indexOf(r)>=0||Object.prototype.propertyIsEnumerable.call(e,r)&&(n[r]=e[r])}return n}var s=a.createContext({}),o=function(e){var t=a.useContext(s),r=t;return e&&(r="function"==typeof e?e(t):p(p({},t),e)),r},d=function(e){var t=o(e.components);return a.createElement(s.Provider,{value:t},e.children)},u={inlineCode:"code",wrapper:function(e){var t=e.children;return a.createElement(a.Fragment,{},t)}},c=a.forwardRef((function(e,t){var r=e.components,n=e.mdxType,i=e.originalType,s=e.parentName,d=l(e,["components","mdxType","originalType","parentName"]),c=o(r),g=n,m=c["".concat(s,".").concat(g)]||c[g]||u[g]||i;return r?a.createElement(m,p(p({ref:t},d),{},{components:r})):a.createElement(m,p({ref:t},d))}));function g(e,t){var r=arguments,n=t&&t.mdxType;if("string"==typeof e||n){var i=r.length,p=new Array(i);p[0]=c;var l={};for(var s in t)hasOwnProperty.call(t,s)&&(l[s]=t[s]);l.originalType=e,l.mdxType="string"==typeof e?e:n,p[1]=l;for(var o=2;o<i;o++)p[o]=r[o];return a.createElement.apply(null,p)}return a.createElement.apply(null,r)}c.displayName="MDXCreateElement"},83986:function(e,t,r){r.r(t),r.d(t,{frontMatter:function(){return l},contentTitle:function(){return s},metadata:function(){return o},toc:function(){return d},default:function(){return c}});var a=r(87462),n=r(63366),i=(r(67294),r(3905)),p=["components"],l={title:"Class TagRegistry",sidebar_label:"TagRegistry",description:"Represents a registry for tags"},s="Class TagRegistry",o={unversionedId:"api/CopperSharp.Registry/TagRegistry",id:"api/CopperSharp.Registry/TagRegistry",title:"Class TagRegistry",description:"Represents a registry for tags",source:"@site/docs/api/CopperSharp.Registry/TagRegistry.md",sourceDirName:"api/CopperSharp.Registry",slug:"/api/CopperSharp.Registry/TagRegistry",permalink:"/docs/api/CopperSharp.Registry/TagRegistry",editUrl:"https://github.com/Maxuss/CopperSharp/docs/api/CopperSharp.Registry/TagRegistry.md",tags:[],version:"current",frontMatter:{title:"Class TagRegistry",sidebar_label:"TagRegistry",description:"Represents a registry for tags"},sidebar:"tutorialSidebar",previous:{title:"Registry<TElement>",permalink:"/docs/api/CopperSharp.Registry/Registry`TElement`"},next:{title:"Index",permalink:"/docs/api/CopperSharp.Tags/"}},d=[{value:"<strong>Assembly</strong>: CopperSharp.dll",id:"assembly-coppersharpdll",children:[],level:6},{value:"View Source",id:"view-source",children:[],level:6},{value:"Properties",id:"properties",children:[{value:"Name",id:"name",children:[{value:"View Source",id:"view-source-1",children:[],level:6}],level:3}],level:2},{value:"Methods",id:"methods",children:[{value:"Register(Tag, Identifier)",id:"registertag-identifier",children:[{value:"View Source",id:"view-source-2",children:[],level:6},{value:"Returns",id:"returns",children:[],level:5},{value:"Parameters",id:"parameters",children:[],level:5}],level:3},{value:"Write((Tag, Identifier), ModuleOutputStream)",id:"writetag-identifier-moduleoutputstream",children:[{value:"View Source",id:"view-source-3",children:[],level:6},{value:"Returns",id:"returns-1",children:[],level:5},{value:"Parameters",id:"parameters-1",children:[],level:5}],level:3}],level:2}],u={toc:d};function c(e){var t=e.components,r=(0,n.Z)(e,p);return(0,i.kt)("wrapper",(0,a.Z)({},u,r,{components:t,mdxType:"MDXLayout"}),(0,i.kt)("h1",{id:"class-tagregistry"},"Class TagRegistry"),(0,i.kt)("p",null,"Represents a registry for tags"),(0,i.kt)("h6",{id:"assembly-coppersharpdll"},(0,i.kt)("strong",{parentName:"h6"},"Assembly"),": CopperSharp.dll"),(0,i.kt)("h6",{id:"view-source"},(0,i.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Registry/TagRegistry.cs#L9"},"View Source")),(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public sealed class TagRegistry : Registry<Tag>\n")),(0,i.kt)("h2",{id:"properties"},"Properties"),(0,i.kt)("h3",{id:"name"},"Name"),(0,i.kt)("p",null,"Name of this registry port"),(0,i.kt)("h6",{id:"view-source-1"},(0,i.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Registry/TagRegistry.cs#L12"},"View Source")),(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"protected override string Name { get; }\n")),(0,i.kt)("h2",{id:"methods"},"Methods"),(0,i.kt)("h3",{id:"registertag-identifier"},"Register(Tag, Identifier)"),(0,i.kt)("p",null,"Registers provided element in current registry"),(0,i.kt)("h6",{id:"view-source-2"},(0,i.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Registry/TagRegistry.cs#L15"},"View Source")),(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public override Tag Register(Tag element, Identifier id)\n")),(0,i.kt)("h5",{id:"returns"},"Returns"),(0,i.kt)("p",null,(0,i.kt)("a",{parentName:"p",href:"../CopperSharp.Tags/Tag"},"CopperSharp.Tags.Tag"),": The provided element"),(0,i.kt)("h5",{id:"parameters"},"Parameters"),(0,i.kt)("table",null,(0,i.kt)("thead",{parentName:"table"},(0,i.kt)("tr",{parentName:"thead"},(0,i.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,i.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,i.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,i.kt)("tbody",{parentName:"table"},(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("a",{parentName:"td",href:"../CopperSharp.Tags/Tag"},"CopperSharp.Tags.Tag")),(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("em",{parentName:"td"},"element")),(0,i.kt)("td",{parentName:"tr",align:"left"})),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("a",{parentName:"td",href:"../CopperSharp.Registry/Identifier"},"CopperSharp.Registry.Identifier")),(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("em",{parentName:"td"},"id")),(0,i.kt)("td",{parentName:"tr",align:"left"},"ID of element to be registered")))),(0,i.kt)("h3",{id:"writetag-identifier-moduleoutputstream"},"Write((Tag, Identifier), ModuleOutputStream)"),(0,i.kt)("p",null,"Writes data to provided stream"),(0,i.kt)("h6",{id:"view-source-3"},(0,i.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Registry/TagRegistry.cs#L22"},"View Source")),(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public override Task Write((Tag, Identifier) element, ModuleOutputStream stream)\n")),(0,i.kt)("h5",{id:"returns-1"},"Returns"),(0,i.kt)("p",null,(0,i.kt)("inlineCode",{parentName:"p"},"Task")),(0,i.kt)("h5",{id:"parameters-1"},"Parameters"),(0,i.kt)("table",null,(0,i.kt)("thead",{parentName:"table"},(0,i.kt)("tr",{parentName:"thead"},(0,i.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,i.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,i.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,i.kt)("tbody",{parentName:"table"},(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("inlineCode",{parentName:"td"},"System.ValueTuple<CopperSharp.Tags.Tag,CopperSharp.Registry.Identifier>")),(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("em",{parentName:"td"},"element")),(0,i.kt)("td",{parentName:"tr",align:"left"})),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("a",{parentName:"td",href:"../CopperSharp.Modules/ModuleOutputStream"},"CopperSharp.Modules.ModuleOutputStream")),(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("em",{parentName:"td"},"stream")),(0,i.kt)("td",{parentName:"tr",align:"left"},"Stream to be used")))))}c.isMDXComponent=!0}}]);