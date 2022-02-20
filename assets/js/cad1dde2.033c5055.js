"use strict";(self.webpackChunkdocs=self.webpackChunkdocs||[]).push([[17636],{3905:function(e,t,r){r.d(t,{Zo:function(){return c},kt:function(){return d}});var a=r(67294);function n(e,t,r){return t in e?Object.defineProperty(e,t,{value:r,enumerable:!0,configurable:!0,writable:!0}):e[t]=r,e}function l(e,t){var r=Object.keys(e);if(Object.getOwnPropertySymbols){var a=Object.getOwnPropertySymbols(e);t&&(a=a.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),r.push.apply(r,a)}return r}function p(e){for(var t=1;t<arguments.length;t++){var r=null!=arguments[t]?arguments[t]:{};t%2?l(Object(r),!0).forEach((function(t){n(e,t,r[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(r)):l(Object(r)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(r,t))}))}return e}function o(e,t){if(null==e)return{};var r,a,n=function(e,t){if(null==e)return{};var r,a,n={},l=Object.keys(e);for(a=0;a<l.length;a++)r=l[a],t.indexOf(r)>=0||(n[r]=e[r]);return n}(e,t);if(Object.getOwnPropertySymbols){var l=Object.getOwnPropertySymbols(e);for(a=0;a<l.length;a++)r=l[a],t.indexOf(r)>=0||Object.prototype.propertyIsEnumerable.call(e,r)&&(n[r]=e[r])}return n}var i=a.createContext({}),s=function(e){var t=a.useContext(i),r=t;return e&&(r="function"==typeof e?e(t):p(p({},t),e)),r},c=function(e){var t=s(e.components);return a.createElement(i.Provider,{value:t},e.children)},u={inlineCode:"code",wrapper:function(e){var t=e.children;return a.createElement(a.Fragment,{},t)}},m=a.forwardRef((function(e,t){var r=e.components,n=e.mdxType,l=e.originalType,i=e.parentName,c=o(e,["components","mdxType","originalType","parentName"]),m=s(r),d=n,h=m["".concat(i,".").concat(d)]||m[d]||u[d]||l;return r?a.createElement(h,p(p({ref:t},c),{},{components:r})):a.createElement(h,p({ref:t},c))}));function d(e,t){var r=arguments,n=t&&t.mdxType;if("string"==typeof e||n){var l=r.length,p=new Array(l);p[0]=m;var o={};for(var i in t)hasOwnProperty.call(t,i)&&(o[i]=t[i]);o.originalType=e,o.mdxType="string"==typeof e?e:n,p[1]=o;for(var s=2;s<l;s++)p[s]=r[s];return a.createElement.apply(null,p)}return a.createElement.apply(null,r)}m.displayName="MDXCreateElement"},30551:function(e,t,r){r.r(t),r.d(t,{frontMatter:function(){return o},contentTitle:function(){return i},metadata:function(){return s},toc:function(){return c},default:function(){return m}});var a=r(87462),n=r(63366),l=(r(67294),r(3905)),p=["components"],o={title:"Class Sapling",sidebar_label:"Sapling",description:"Represents a growable tile entity"},i="Class Sapling",s={unversionedId:"api/CopperSharp.Blocks.Data.Impl/Sapling",id:"api/CopperSharp.Blocks.Data.Impl/Sapling",title:"Class Sapling",description:"Represents a growable tile entity",source:"@site/docs/api/CopperSharp.Blocks.Data.Impl/Sapling.md",sourceDirName:"api/CopperSharp.Blocks.Data.Impl",slug:"/api/CopperSharp.Blocks.Data.Impl/Sapling",permalink:"/docs/api/CopperSharp.Blocks.Data.Impl/Sapling",editUrl:"https://github.com/Maxuss/CopperSharp/docs/api/CopperSharp.Blocks.Data.Impl/Sapling.md",tags:[],version:"current",frontMatter:{title:"Class Sapling",sidebar_label:"Sapling",description:"Represents a growable tile entity"},sidebar:"tutorialSidebar",previous:{title:"RespawnAnchor",permalink:"/docs/api/CopperSharp.Blocks.Data.Impl/RespawnAnchor"},next:{title:"Scaffolding",permalink:"/docs/api/CopperSharp.Blocks.Data.Impl/Scaffolding"}},c=[{value:"<strong>Assembly</strong>: CopperSharp.dll",id:"assembly-coppersharpdll",children:[],level:6},{value:"View Source",id:"view-source",children:[],level:6},{value:"Methods",id:"methods",children:[{value:"Growing(Boolean)",id:"growingboolean",children:[{value:"View Source",id:"view-source-1",children:[],level:6},{value:"Returns",id:"returns",children:[],level:5},{value:"Parameters",id:"parameters",children:[],level:5}],level:3}],level:2},{value:"Implements",id:"implements",children:[],level:2}],u={toc:c};function m(e){var t=e.components,r=(0,n.Z)(e,p);return(0,l.kt)("wrapper",(0,a.Z)({},u,r,{components:t,mdxType:"MDXLayout"}),(0,l.kt)("h1",{id:"class-sapling"},"Class Sapling"),(0,l.kt)("p",null,"Represents a growable tile entity"),(0,l.kt)("h6",{id:"assembly-coppersharpdll"},(0,l.kt)("strong",{parentName:"h6"},"Assembly"),": CopperSharp.dll"),(0,l.kt)("h6",{id:"view-source"},(0,l.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/Impl/Sapling.cs#L6"},"View Source")),(0,l.kt)("pre",null,(0,l.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public class Sapling : AbstractBlockData, IBlockData\n")),(0,l.kt)("h2",{id:"methods"},"Methods"),(0,l.kt)("h3",{id:"growingboolean"},"Growing(Boolean)"),(0,l.kt)("p",null,"Whether this sapling is trying to grow"),(0,l.kt)("h6",{id:"view-source-1"},(0,l.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/Impl/Sapling.cs#L13"},"View Source")),(0,l.kt)("pre",null,(0,l.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public Sapling Growing(bool growing)\n")),(0,l.kt)("h5",{id:"returns"},"Returns"),(0,l.kt)("p",null,(0,l.kt)("a",{parentName:"p",href:"../CopperSharp.Blocks.Data.Impl/Sapling"},"CopperSharp.Blocks.Data.Impl.Sapling"),": This sapling entity"),(0,l.kt)("h5",{id:"parameters"},"Parameters"),(0,l.kt)("table",null,(0,l.kt)("thead",{parentName:"table"},(0,l.kt)("tr",{parentName:"thead"},(0,l.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,l.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,l.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,l.kt)("tbody",{parentName:"table"},(0,l.kt)("tr",{parentName:"tbody"},(0,l.kt)("td",{parentName:"tr",align:"left"},(0,l.kt)("inlineCode",{parentName:"td"},"System.Boolean")),(0,l.kt)("td",{parentName:"tr",align:"left"},(0,l.kt)("em",{parentName:"td"},"growing")),(0,l.kt)("td",{parentName:"tr",align:"left"},"Whether it is possible for sapling to grow")))),(0,l.kt)("h2",{id:"implements"},"Implements"),(0,l.kt)("ul",null,(0,l.kt)("li",{parentName:"ul"},(0,l.kt)("a",{parentName:"li",href:"../CopperSharp.Blocks.Data/IBlockData"},"CopperSharp.Blocks.Data.IBlockData"))))}m.isMDXComponent=!0}}]);