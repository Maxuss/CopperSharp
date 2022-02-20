"use strict";(self.webpackChunkdocs=self.webpackChunkdocs||[]).push([[81527],{3905:function(e,t,r){r.d(t,{Zo:function(){return s},kt:function(){return d}});var a=r(67294);function l(e,t,r){return t in e?Object.defineProperty(e,t,{value:r,enumerable:!0,configurable:!0,writable:!0}):e[t]=r,e}function n(e,t){var r=Object.keys(e);if(Object.getOwnPropertySymbols){var a=Object.getOwnPropertySymbols(e);t&&(a=a.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),r.push.apply(r,a)}return r}function o(e){for(var t=1;t<arguments.length;t++){var r=null!=arguments[t]?arguments[t]:{};t%2?n(Object(r),!0).forEach((function(t){l(e,t,r[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(r)):n(Object(r)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(r,t))}))}return e}function i(e,t){if(null==e)return{};var r,a,l=function(e,t){if(null==e)return{};var r,a,l={},n=Object.keys(e);for(a=0;a<n.length;a++)r=n[a],t.indexOf(r)>=0||(l[r]=e[r]);return l}(e,t);if(Object.getOwnPropertySymbols){var n=Object.getOwnPropertySymbols(e);for(a=0;a<n.length;a++)r=n[a],t.indexOf(r)>=0||Object.prototype.propertyIsEnumerable.call(e,r)&&(l[r]=e[r])}return l}var p=a.createContext({}),c=function(e){var t=a.useContext(p),r=t;return e&&(r="function"==typeof e?e(t):o(o({},t),e)),r},s=function(e){var t=c(e.components);return a.createElement(p.Provider,{value:t},e.children)},u={inlineCode:"code",wrapper:function(e){var t=e.children;return a.createElement(a.Fragment,{},t)}},k=a.forwardRef((function(e,t){var r=e.components,l=e.mdxType,n=e.originalType,p=e.parentName,s=i(e,["components","mdxType","originalType","parentName"]),k=c(r),d=l,m=k["".concat(p,".").concat(d)]||k[d]||u[d]||n;return r?a.createElement(m,o(o({ref:t},s),{},{components:r})):a.createElement(m,o({ref:t},s))}));function d(e,t){var r=arguments,l=t&&t.mdxType;if("string"==typeof e||l){var n=r.length,o=new Array(n);o[0]=k;var i={};for(var p in t)hasOwnProperty.call(t,p)&&(i[p]=t[p]);i.originalType=e,i.mdxType="string"==typeof e?e:l,o[1]=i;for(var c=2;c<n;c++)o[c]=r[c];return a.createElement.apply(null,o)}return a.createElement.apply(null,r)}k.displayName="MDXCreateElement"},61977:function(e,t,r){r.r(t),r.d(t,{frontMatter:function(){return i},contentTitle:function(){return p},metadata:function(){return c},toc:function(){return s},default:function(){return k}});var a=r(87462),l=r(63366),n=(r(67294),r(3905)),o=["components"],i={title:"Class BlockState",sidebar_label:"BlockState",description:"An abstract superclass for all block states"},p="Class BlockState",c={unversionedId:"api/CopperSharp.Blocks/BlockState",id:"api/CopperSharp.Blocks/BlockState",title:"Class BlockState",description:"An abstract superclass for all block states",source:"@site/docs/api/CopperSharp.Blocks/BlockState.md",sourceDirName:"api/CopperSharp.Blocks",slug:"/api/CopperSharp.Blocks/BlockState",permalink:"/docs/api/CopperSharp.Blocks/BlockState",editUrl:"https://github.com/Maxuss/CopperSharp/docs/api/CopperSharp.Blocks/BlockState.md",tags:[],version:"current",frontMatter:{title:"Class BlockState",sidebar_label:"BlockState",description:"An abstract superclass for all block states"},sidebar:"tutorialSidebar",previous:{title:"Block",permalink:"/docs/api/CopperSharp.Blocks/Block"},next:{title:"EntityBlockState<TEntity>",permalink:"/docs/api/CopperSharp.Blocks/EntityBlockState`TEntity`"}},s=[{value:"<strong>Assembly</strong>: CopperSharp.dll",id:"assembly-coppersharpdll",children:[],level:6},{value:"View Source",id:"view-source",children:[],level:6},{value:"Properties",id:"properties",children:[{value:"Data",id:"data",children:[{value:"View Source",id:"view-source-1",children:[],level:6}],level:3},{value:"BlockData",id:"blockdata",children:[{value:"View Source",id:"view-source-2",children:[],level:6}],level:3}],level:2},{value:"Methods",id:"methods",children:[{value:"Serialize()",id:"serialize",children:[{value:"View Source",id:"view-source-3",children:[],level:6},{value:"Returns",id:"returns",children:[{value:"View Source",id:"view-source-4",children:[],level:6}],level:5},{value:"Returns",id:"returns-1",children:[],level:5},{value:"Parameters",id:"parameters",children:[],level:5}],level:3}],level:2},{value:"Implements",id:"implements",children:[],level:2}],u={toc:s};function k(e){var t=e.components,r=(0,l.Z)(e,o);return(0,n.kt)("wrapper",(0,a.Z)({},u,r,{components:t,mdxType:"MDXLayout"}),(0,n.kt)("h1",{id:"class-blockstate"},"Class BlockState"),(0,n.kt)("p",null,"An abstract superclass for all block states"),(0,n.kt)("h6",{id:"assembly-coppersharpdll"},(0,n.kt)("strong",{parentName:"h6"},"Assembly"),": CopperSharp.dll"),(0,n.kt)("h6",{id:"view-source"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/BlockState.cs#L12"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public abstract class BlockState : object, IState\n")),(0,n.kt)("h2",{id:"properties"},"Properties"),(0,n.kt)("h3",{id:"data"},"Data"),(0,n.kt)("p",null,"Extra NBT data for this block state"),(0,n.kt)("h6",{id:"view-source-1"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/BlockState.cs#L30"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"protected NbtCompound Data { get; set; }\n")),(0,n.kt)("h3",{id:"blockdata"},"BlockData"),(0,n.kt)("p",null,"Extra data on this block"),(0,n.kt)("h6",{id:"view-source-2"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/BlockState.cs#L33"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public virtual IBlockData BlockData { get; set; }\n")),(0,n.kt)("h2",{id:"methods"},"Methods"),(0,n.kt)("h3",{id:"serialize"},"Serialize()"),(0,n.kt)("p",null,"Serializes this block state into stringified NBT"),(0,n.kt)("h6",{id:"view-source-3"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/BlockState.cs#L36"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public Task<string> Serialize()\n")),(0,n.kt)("h5",{id:"returns"},"Returns"),(0,n.kt)("p",null,(0,n.kt)("inlineCode",{parentName:"p"},"Task<System.String>"),": Stringified NBT of this block state### CustomName(Component)\nSets custom name of this block state"),(0,n.kt)("h6",{id:"view-source-4"},(0,n.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Blocks/BlockState.cs#L57"},"View Source")),(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public Task<BlockState> CustomName(Component name)\n")),(0,n.kt)("h5",{id:"returns-1"},"Returns"),(0,n.kt)("p",null,(0,n.kt)("inlineCode",{parentName:"p"},"Task<CopperSharp.Blocks.BlockState>"),": This block state"),(0,n.kt)("h5",{id:"parameters"},"Parameters"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("a",{parentName:"td",href:"../CopperSharp.Text/Component"},"CopperSharp.Text.Component")),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("em",{parentName:"td"},"name")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Name to be set")))),(0,n.kt)("h2",{id:"implements"},"Implements"),(0,n.kt)("ul",null,(0,n.kt)("li",{parentName:"ul"},(0,n.kt)("a",{parentName:"li",href:"../CopperSharp.Blocks/IState"},"CopperSharp.Blocks.IState"))))}k.isMDXComponent=!0}}]);