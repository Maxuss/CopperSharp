"use strict";(self.webpackChunkdocs=self.webpackChunkdocs||[]).push([[36157],{3905:function(e,t,a){a.d(t,{Zo:function(){return c},kt:function(){return d}});var r=a(67294);function l(e,t,a){return t in e?Object.defineProperty(e,t,{value:a,enumerable:!0,configurable:!0,writable:!0}):e[t]=a,e}function n(e,t){var a=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),a.push.apply(a,r)}return a}function p(e){for(var t=1;t<arguments.length;t++){var a=null!=arguments[t]?arguments[t]:{};t%2?n(Object(a),!0).forEach((function(t){l(e,t,a[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(a)):n(Object(a)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(a,t))}))}return e}function o(e,t){if(null==e)return{};var a,r,l=function(e,t){if(null==e)return{};var a,r,l={},n=Object.keys(e);for(r=0;r<n.length;r++)a=n[r],t.indexOf(a)>=0||(l[a]=e[a]);return l}(e,t);if(Object.getOwnPropertySymbols){var n=Object.getOwnPropertySymbols(e);for(r=0;r<n.length;r++)a=n[r],t.indexOf(a)>=0||Object.prototype.propertyIsEnumerable.call(e,a)&&(l[a]=e[a])}return l}var i=r.createContext({}),s=function(e){var t=r.useContext(i),a=t;return e&&(a="function"==typeof e?e(t):p(p({},t),e)),a},c=function(e){var t=s(e.components);return r.createElement(i.Provider,{value:t},e.children)},m={inlineCode:"code",wrapper:function(e){var t=e.children;return r.createElement(r.Fragment,{},t)}},h=r.forwardRef((function(e,t){var a=e.components,l=e.mdxType,n=e.originalType,i=e.parentName,c=o(e,["components","mdxType","originalType","parentName"]),h=s(a),d=l,u=h["".concat(i,".").concat(d)]||h[d]||m[d]||n;return a?r.createElement(u,p(p({ref:t},c),{},{components:a})):r.createElement(u,p({ref:t},c))}));function d(e,t){var a=arguments,l=t&&t.mdxType;if("string"==typeof e||l){var n=a.length,p=new Array(n);p[0]=h;var o={};for(var i in t)hasOwnProperty.call(t,i)&&(o[i]=t[i]);o.originalType=e,o.mdxType="string"==typeof e?e:l,p[1]=o;for(var s=2;s<n;s++)p[s]=a[s];return r.createElement.apply(null,p)}return r.createElement.apply(null,a)}h.displayName="MDXCreateElement"},57179:function(e,t,a){a.r(t),a.d(t,{frontMatter:function(){return o},contentTitle:function(){return i},metadata:function(){return s},toc:function(){return c},default:function(){return h}});var r=a(87462),l=a(63366),n=(a(67294),a(3905)),p=["components"],o={title:"Class Wall",sidebar_label:"Wall",description:"Represents a wall block"},i="Class Wall",s={unversionedId:"api/CopperSharp.Blocks.Data.Impl/Wall",id:"api/CopperSharp.Blocks.Data.Impl/Wall",title:"Class Wall",description:"Represents a wall block",source:"@site/docs/api/CopperSharp.Blocks.Data.Impl/Wall.md",sourceDirName:"api/CopperSharp.Blocks.Data.Impl",slug:"/api/CopperSharp.Blocks.Data.Impl/Wall",permalink:"/docs/api/CopperSharp.Blocks.Data.Impl/Wall",editUrl:"https://github.com/Maxuss/CopperSharp/docs/api/CopperSharp.Blocks.Data.Impl/Wall.md",tags:[],version:"current",frontMatter:{title:"Class Wall",sidebar_label:"Wall",description:"Represents a wall block"},sidebar:"tutorialSidebar",previous:{title:"Wall.Height",permalink:"/docs/api/CopperSharp.Blocks.Data.Impl/Wall.Height"},next:{title:"WallSign",permalink:"/docs/api/CopperSharp.Blocks.Data.Impl/WallSign"}},c=[{value:"<strong>Assembly</strong>: CopperSharp.dll",id:"assembly-coppersharpdll",children:[],level:6},{value:"View Source",id:"view-source",children:[],level:6},{value:"Methods",id:"methods",children:[{value:"Waterlogged(Boolean)",id:"waterloggedboolean",children:[{value:"View Source",id:"view-source-1",children:[],level:6},{value:"Returns",id:"returns",children:[],level:5},{value:"Parameters",id:"parameters",children:[],level:5}],level:3},{value:"HeightAt(BlockFace, Wall.Height)",id:"heightatblockface-wallheight",children:[{value:"View Source",id:"view-source-2",children:[],level:6},{value:"Returns",id:"returns-1",children:[],level:5},{value:"Parameters",id:"parameters-1",children:[],level:5}],level:3},{value:"CenterPost(Boolean)",id:"centerpostboolean",children:[{value:"View Source",id:"view-source-3",children:[],level:6},{value:"Returns",id:"returns-2",children:[],level:5},{value:"Parameters",id:"parameters-2",children:[],level:5}],level:3}],level:2},{value:"Implements",id:"implements",children:[],level:2}],m={toc:c};function h(e){var t=e.components,a=(0,l.Z)(e,p);return(0,n.kt)("wrapper",(0,r.Z)({},m,a,{components:t,mdxType:"MDXLayout"}),(0,n.kt)("h1",{id:"class-wall"},"Class Wall"),(0,n.kt)("p",null,"Represents a wall block"),(0,n.kt)("h6",{id:"assembly-coppersharpdll"},(0,n.kt)("strong",{parentName:"h6"},"Assembly"),": CopperSharp.dll"),(0,n.kt)("h6",{id:"view-source"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/Impl/Wall.cs#L6"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public sealed class Wall : AbstractBlockData, IWaterlogged, IBlockData\n")),(0,n.kt)("h2",{id:"methods"},"Methods"),(0,n.kt)("h3",{id:"waterloggedboolean"},"Waterlogged(Boolean)"),(0,n.kt)("p",null,"Makes this block entity waterlogged"),(0,n.kt)("h6",{id:"view-source-1"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/Impl/Wall.cs#L30"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public IWaterlogged Waterlogged(bool logged = true)\n")),(0,n.kt)("h5",{id:"returns"},"Returns"),(0,n.kt)("p",null,(0,n.kt)("a",{parentName:"p",href:"../CopperSharp.Blocks.Data/IWaterlogged"},"CopperSharp.Blocks.Data.IWaterlogged"),": This block entity"),(0,n.kt)("h5",{id:"parameters"},"Parameters"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("inlineCode",{parentName:"td"},"System.Boolean")),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("em",{parentName:"td"},"logged")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Whether to make this block entity waterlogged")))),(0,n.kt)("h3",{id:"heightatblockface-wallheight"},"HeightAt(BlockFace, Wall.Height)"),(0,n.kt)("p",null,"Sets how the wall extends at provided block face"),(0,n.kt)("h6",{id:"view-source-2"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/Impl/Wall.cs#L42"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public Wall HeightAt(BlockFace face, Wall.Height extends)\n")),(0,n.kt)("h5",{id:"returns-1"},"Returns"),(0,n.kt)("p",null,(0,n.kt)("a",{parentName:"p",href:"../CopperSharp.Blocks.Data.Impl/Wall"},"CopperSharp.Blocks.Data.Impl.Wall"),": This wall"),(0,n.kt)("h5",{id:"parameters-1"},"Parameters"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("a",{parentName:"td",href:"../CopperSharp.Blocks.Data/BlockFace"},"CopperSharp.Blocks.Data.BlockFace")),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("em",{parentName:"td"},"face")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Face at which the wall extends")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("a",{parentName:"td",href:"../CopperSharp.Blocks.Data.Impl/Wall.Height"},"CopperSharp.Blocks.Data.Impl.Wall.Height")),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("em",{parentName:"td"},"extends")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets amount of the wall","'","s extend")))),(0,n.kt)("h3",{id:"centerpostboolean"},"CenterPost(Boolean)"),(0,n.kt)("p",null,"Sets whether this wall has a center post"),(0,n.kt)("h6",{id:"view-source-3"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/Impl/Wall.cs#L56"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public Wall CenterPost(bool up = true)\n")),(0,n.kt)("h5",{id:"returns-2"},"Returns"),(0,n.kt)("p",null,(0,n.kt)("a",{parentName:"p",href:"../CopperSharp.Blocks.Data.Impl/Wall"},"CopperSharp.Blocks.Data.Impl.Wall"),": This wall"),(0,n.kt)("h5",{id:"parameters-2"},"Parameters"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("inlineCode",{parentName:"td"},"System.Boolean")),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("em",{parentName:"td"},"up")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Marker")))),(0,n.kt)("h2",{id:"implements"},"Implements"),(0,n.kt)("ul",null,(0,n.kt)("li",{parentName:"ul"},(0,n.kt)("a",{parentName:"li",href:"../CopperSharp.Blocks.Data/IWaterlogged"},"CopperSharp.Blocks.Data.IWaterlogged")),(0,n.kt)("li",{parentName:"ul"},(0,n.kt)("a",{parentName:"li",href:"../CopperSharp.Blocks.Data/IBlockData"},"CopperSharp.Blocks.Data.IBlockData"))))}h.isMDXComponent=!0}}]);