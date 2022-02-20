"use strict";(self.webpackChunkdocs=self.webpackChunkdocs||[]).push([[99487],{3905:function(e,t,a){a.d(t,{Zo:function(){return s},kt:function(){return k}});var r=a(67294);function l(e,t,a){return t in e?Object.defineProperty(e,t,{value:a,enumerable:!0,configurable:!0,writable:!0}):e[t]=a,e}function n(e,t){var a=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),a.push.apply(a,r)}return a}function i(e){for(var t=1;t<arguments.length;t++){var a=null!=arguments[t]?arguments[t]:{};t%2?n(Object(a),!0).forEach((function(t){l(e,t,a[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(a)):n(Object(a)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(a,t))}))}return e}function o(e,t){if(null==e)return{};var a,r,l=function(e,t){if(null==e)return{};var a,r,l={},n=Object.keys(e);for(r=0;r<n.length;r++)a=n[r],t.indexOf(a)>=0||(l[a]=e[a]);return l}(e,t);if(Object.getOwnPropertySymbols){var n=Object.getOwnPropertySymbols(e);for(r=0;r<n.length;r++)a=n[r],t.indexOf(a)>=0||Object.prototype.propertyIsEnumerable.call(e,a)&&(l[a]=e[a])}return l}var p=r.createContext({}),c=function(e){var t=r.useContext(p),a=t;return e&&(a="function"==typeof e?e(t):i(i({},t),e)),a},s=function(e){var t=c(e.components);return r.createElement(p.Provider,{value:t},e.children)},u={inlineCode:"code",wrapper:function(e){var t=e.children;return r.createElement(r.Fragment,{},t)}},d=r.forwardRef((function(e,t){var a=e.components,l=e.mdxType,n=e.originalType,p=e.parentName,s=o(e,["components","mdxType","originalType","parentName"]),d=c(a),k=l,m=d["".concat(p,".").concat(k)]||d[k]||u[k]||n;return a?r.createElement(m,i(i({ref:t},s),{},{components:a})):r.createElement(m,i({ref:t},s))}));function k(e,t){var a=arguments,l=t&&t.mdxType;if("string"==typeof e||l){var n=a.length,i=new Array(n);i[0]=d;var o={};for(var p in t)hasOwnProperty.call(t,p)&&(o[p]=t[p]);o.originalType=e,o.mdxType="string"==typeof e?e:l,i[1]=o;for(var c=2;c<n;c++)i[c]=a[c];return r.createElement.apply(null,i)}return r.createElement.apply(null,a)}d.displayName="MDXCreateElement"},88314:function(e,t,a){a.r(t),a.d(t,{frontMatter:function(){return o},contentTitle:function(){return p},metadata:function(){return c},toc:function(){return s},default:function(){return d}});var r=a(87462),l=a(63366),n=(a(67294),a(3905)),i=["components"],o={title:"Class AbstractBlockData",sidebar_label:"AbstractBlockData",description:"Abstract implementation for block entity"},p="Class AbstractBlockData",c={unversionedId:"api/CopperSharp.Blocks.Data/AbstractBlockData",id:"api/CopperSharp.Blocks.Data/AbstractBlockData",title:"Class AbstractBlockData",description:"Abstract implementation for block entity",source:"@site/docs/api/CopperSharp.Blocks.Data/AbstractBlockData.md",sourceDirName:"api/CopperSharp.Blocks.Data",slug:"/api/CopperSharp.Blocks.Data/AbstractBlockData",permalink:"/docs/api/CopperSharp.Blocks.Data/AbstractBlockData",editUrl:"https://github.com/Maxuss/CopperSharp/docs/api/CopperSharp.Blocks.Data/AbstractBlockData.md",tags:[],version:"current",frontMatter:{title:"Class AbstractBlockData",sidebar_label:"AbstractBlockData",description:"Abstract implementation for block entity"},sidebar:"tutorialSidebar",previous:{title:"Index",permalink:"/docs/api/CopperSharp.Blocks.Data/"},next:{title:"Axis",permalink:"/docs/api/CopperSharp.Blocks.Data/Axis"}},s=[{value:"<strong>Assembly</strong>: CopperSharp.dll",id:"assembly-coppersharpdll",children:[],level:6},{value:"View Source",id:"view-source",children:[],level:6},{value:"Properties",id:"properties",children:[{value:"Data",id:"data",children:[{value:"View Source",id:"view-source-1",children:[],level:6}],level:3}],level:2},{value:"Methods",id:"methods",children:[{value:"IsInvalidated(Boolean)",id:"isinvalidatedboolean",children:[{value:"View Source",id:"view-source-2",children:[],level:6},{value:"Returns",id:"returns",children:[],level:5},{value:"Parameters",id:"parameters",children:[],level:5}],level:3},{value:"SerializeInto(INbtWriter)",id:"serializeintoinbtwriter",children:[{value:"View Source",id:"view-source-3",children:[],level:6},{value:"Returns",id:"returns-1",children:[],level:5},{value:"Parameters",id:"parameters-1",children:[],level:5}],level:3},{value:"Serialize()",id:"serialize",children:[{value:"View Source",id:"view-source-4",children:[],level:6},{value:"Returns",id:"returns-2",children:[],level:5}],level:3}],level:2},{value:"Implements",id:"implements",children:[],level:2}],u={toc:s};function d(e){var t=e.components,a=(0,l.Z)(e,i);return(0,n.kt)("wrapper",(0,r.Z)({},u,a,{components:t,mdxType:"MDXLayout"}),(0,n.kt)("h1",{id:"class-abstractblockdata"},"Class AbstractBlockData"),(0,n.kt)("p",null,"Abstract implementation for block entity"),(0,n.kt)("h6",{id:"assembly-coppersharpdll"},(0,n.kt)("strong",{parentName:"h6"},"Assembly"),": CopperSharp.dll"),(0,n.kt)("h6",{id:"view-source"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/AbstractBlockData.cs#L8"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public abstract class AbstractBlockData : object, IBlockData\n")),(0,n.kt)("h2",{id:"properties"},"Properties"),(0,n.kt)("h3",{id:"data"},"Data"),(0,n.kt)("p",null,"All extra NBT data for this tile entity"),(0,n.kt)("h6",{id:"view-source-1"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/AbstractBlockData.cs#L11"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public NbtCompound Data { get; set; }\n")),(0,n.kt)("h2",{id:"methods"},"Methods"),(0,n.kt)("h3",{id:"isinvalidatedboolean"},"IsInvalidated(Boolean)"),(0,n.kt)("p",null,"Whether this entity is invalidated, and thus does\nnot immediately place the block in a loaded chunk"),(0,n.kt)("h6",{id:"view-source-2"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/AbstractBlockData.cs#L14"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public IBlockData IsInvalidated(bool inv = true)\n")),(0,n.kt)("h5",{id:"returns"},"Returns"),(0,n.kt)("p",null,(0,n.kt)("a",{parentName:"p",href:"../CopperSharp.Blocks.Data/IBlockData"},"CopperSharp.Blocks.Data.IBlockData"),": This abstract block entity"),(0,n.kt)("h5",{id:"parameters"},"Parameters"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("inlineCode",{parentName:"td"},"System.Boolean")),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("em",{parentName:"td"},"inv")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Marker")))),(0,n.kt)("h3",{id:"serializeintoinbtwriter"},"SerializeInto(INbtWriter)"),(0,n.kt)("p",null,"Serializes this block data into provided writer"),(0,n.kt)("h6",{id:"view-source-3"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/AbstractBlockData.cs#L21"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public Task SerializeInto(INbtWriter w)\n")),(0,n.kt)("h5",{id:"returns-1"},"Returns"),(0,n.kt)("p",null,(0,n.kt)("inlineCode",{parentName:"p"},"Task")),(0,n.kt)("h5",{id:"parameters-1"},"Parameters"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("a",{parentName:"td",href:"../CopperSharp.Data.SNbt/INbtWriter"},"CopperSharp.Data.SNbt.INbtWriter")),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("em",{parentName:"td"},"w")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Writer to be used")))),(0,n.kt)("h3",{id:"serialize"},"Serialize()"),(0,n.kt)("p",null,"Serializes this entity into SNBT"),(0,n.kt)("h6",{id:"view-source-4"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/Data/AbstractBlockData.cs#L32"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public Task<string> Serialize()\n")),(0,n.kt)("h5",{id:"returns-2"},"Returns"),(0,n.kt)("p",null,(0,n.kt)("inlineCode",{parentName:"p"},"Task<System.String>"),": Serialized entity"),(0,n.kt)("h2",{id:"implements"},"Implements"),(0,n.kt)("ul",null,(0,n.kt)("li",{parentName:"ul"},(0,n.kt)("a",{parentName:"li",href:"../CopperSharp.Blocks.Data/IBlockData"},"CopperSharp.Blocks.Data.IBlockData"))))}d.isMDXComponent=!0}}]);