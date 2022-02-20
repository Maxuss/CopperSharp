"use strict";(self.webpackChunkdocs=self.webpackChunkdocs||[]).push([[60926],{3905:function(e,t,r){r.d(t,{Zo:function(){return s},kt:function(){return d}});var a=r(67294);function l(e,t,r){return t in e?Object.defineProperty(e,t,{value:r,enumerable:!0,configurable:!0,writable:!0}):e[t]=r,e}function n(e,t){var r=Object.keys(e);if(Object.getOwnPropertySymbols){var a=Object.getOwnPropertySymbols(e);t&&(a=a.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),r.push.apply(r,a)}return r}function o(e){for(var t=1;t<arguments.length;t++){var r=null!=arguments[t]?arguments[t]:{};t%2?n(Object(r),!0).forEach((function(t){l(e,t,r[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(r)):n(Object(r)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(r,t))}))}return e}function p(e,t){if(null==e)return{};var r,a,l=function(e,t){if(null==e)return{};var r,a,l={},n=Object.keys(e);for(a=0;a<n.length;a++)r=n[a],t.indexOf(r)>=0||(l[r]=e[r]);return l}(e,t);if(Object.getOwnPropertySymbols){var n=Object.getOwnPropertySymbols(e);for(a=0;a<n.length;a++)r=n[a],t.indexOf(r)>=0||Object.prototype.propertyIsEnumerable.call(e,r)&&(l[r]=e[r])}return l}var i=a.createContext({}),c=function(e){var t=a.useContext(i),r=t;return e&&(r="function"==typeof e?e(t):o(o({},t),e)),r},s=function(e){var t=c(e.components);return a.createElement(i.Provider,{value:t},e.children)},u={inlineCode:"code",wrapper:function(e){var t=e.children;return a.createElement(a.Fragment,{},t)}},m=a.forwardRef((function(e,t){var r=e.components,l=e.mdxType,n=e.originalType,i=e.parentName,s=p(e,["components","mdxType","originalType","parentName"]),m=c(r),d=l,h=m["".concat(i,".").concat(d)]||m[d]||u[d]||n;return r?a.createElement(h,o(o({ref:t},s),{},{components:r})):a.createElement(h,o({ref:t},s))}));function d(e,t){var r=arguments,l=t&&t.mdxType;if("string"==typeof e||l){var n=r.length,o=new Array(n);o[0]=m;var p={};for(var i in t)hasOwnProperty.call(t,i)&&(p[i]=t[i]);p.originalType=e,p.mdxType="string"==typeof e?e:l,o[1]=p;for(var c=2;c<n;c++)o[c]=r[c];return a.createElement.apply(null,o)}return a.createElement.apply(null,r)}m.displayName="MDXCreateElement"},4707:function(e,t,r){r.r(t),r.d(t,{frontMatter:function(){return p},contentTitle:function(){return i},metadata:function(){return c},toc:function(){return s},default:function(){return m}});var a=r(87462),l=r(63366),n=(r(67294),r(3905)),o=["components"],p={title:"Class Observer",sidebar_label:"Observer",description:"Represents an observer block"},i="Class Observer",c={unversionedId:"api/CopperSharp.Blocks.Data.Impl/Observer",id:"api/CopperSharp.Blocks.Data.Impl/Observer",title:"Class Observer",description:"Represents an observer block",source:"@site/docs/api/CopperSharp.Blocks.Data.Impl/Observer.md",sourceDirName:"api/CopperSharp.Blocks.Data.Impl",slug:"/api/CopperSharp.Blocks.Data.Impl/Observer",permalink:"/docs/api/CopperSharp.Blocks.Data.Impl/Observer",editUrl:"https://github.com/Maxuss/CopperSharp/docs/api/CopperSharp.Blocks.Data.Impl/Observer.md",tags:[],version:"current",frontMatter:{title:"Class Observer",sidebar_label:"Observer",description:"Represents an observer block"},sidebar:"tutorialSidebar",previous:{title:"NoteBlock",permalink:"/docs/api/CopperSharp.Blocks.Data.Impl/NoteBlock"},next:{title:"Piston",permalink:"/docs/api/CopperSharp.Blocks.Data.Impl/Piston"}},s=[{value:"<strong>Assembly</strong>: CopperSharp.dll",id:"assembly-coppersharpdll",children:[],level:6},{value:"View Source",id:"view-source",children:[],level:6},{value:"Methods",id:"methods",children:[{value:"Facing(BlockFace)",id:"facingblockface",children:[{value:"View Source",id:"view-source-1",children:[],level:6},{value:"Returns",id:"returns",children:[],level:5},{value:"Parameters",id:"parameters",children:[],level:5}],level:3},{value:"Powered(Boolean)",id:"poweredboolean",children:[{value:"View Source",id:"view-source-2",children:[],level:6},{value:"Returns",id:"returns-1",children:[],level:5},{value:"Parameters",id:"parameters-1",children:[],level:5}],level:3}],level:2},{value:"Implements",id:"implements",children:[],level:2}],u={toc:s};function m(e){var t=e.components,r=(0,l.Z)(e,o);return(0,n.kt)("wrapper",(0,a.Z)({},u,r,{components:t,mdxType:"MDXLayout"}),(0,n.kt)("h1",{id:"class-observer"},"Class Observer"),(0,n.kt)("p",null,"Represents an observer block"),(0,n.kt)("h6",{id:"assembly-coppersharpdll"},(0,n.kt)("strong",{parentName:"h6"},"Assembly"),": CopperSharp.dll"),(0,n.kt)("h6",{id:"view-source"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/Impl/Observer.cs#L6"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public sealed class Observer : AbstractBlockData, IDirectional, IPowerable, IBlockData\n")),(0,n.kt)("h2",{id:"methods"},"Methods"),(0,n.kt)("h3",{id:"facingblockface"},"Facing(BlockFace)"),(0,n.kt)("p",null,"Sets facing rotation of this directional entity"),(0,n.kt)("h6",{id:"view-source-1"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/Impl/Observer.cs#L12"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public IDirectional Facing(BlockFace face)\n")),(0,n.kt)("h5",{id:"returns"},"Returns"),(0,n.kt)("p",null,(0,n.kt)("a",{parentName:"p",href:"../CopperSharp.Blocks.Data/IDirectional"},"CopperSharp.Blocks.Data.IDirectional"),": This directional entity"),(0,n.kt)("h5",{id:"parameters"},"Parameters"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("a",{parentName:"td",href:"../CopperSharp.Blocks.Data/BlockFace"},"CopperSharp.Blocks.Data.BlockFace")),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("em",{parentName:"td"},"face")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Face to be set")))),(0,n.kt)("h3",{id:"poweredboolean"},"Powered(Boolean)"),(0,n.kt)("p",null,"Whether to make this tile entity powered"),(0,n.kt)("h6",{id:"view-source-2"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/Impl/Observer.cs#L22"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public IPowerable Powered(bool power)\n")),(0,n.kt)("h5",{id:"returns-1"},"Returns"),(0,n.kt)("p",null,(0,n.kt)("a",{parentName:"p",href:"../CopperSharp.Blocks.Data/IPowerable"},"CopperSharp.Blocks.Data.IPowerable"),": This powerable entity"),(0,n.kt)("h5",{id:"parameters-1"},"Parameters"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("inlineCode",{parentName:"td"},"System.Boolean")),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("em",{parentName:"td"},"power")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Whether to make this tile entity powered")))),(0,n.kt)("h2",{id:"implements"},"Implements"),(0,n.kt)("ul",null,(0,n.kt)("li",{parentName:"ul"},(0,n.kt)("a",{parentName:"li",href:"../CopperSharp.Blocks.Data/IDirectional"},"CopperSharp.Blocks.Data.IDirectional")),(0,n.kt)("li",{parentName:"ul"},(0,n.kt)("a",{parentName:"li",href:"../CopperSharp.Blocks.Data/IPowerable"},"CopperSharp.Blocks.Data.IPowerable")),(0,n.kt)("li",{parentName:"ul"},(0,n.kt)("a",{parentName:"li",href:"../CopperSharp.Blocks.Data/IBlockData"},"CopperSharp.Blocks.Data.IBlockData"))))}m.isMDXComponent=!0}}]);