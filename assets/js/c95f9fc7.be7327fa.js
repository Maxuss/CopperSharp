"use strict";(self.webpackChunkdocs=self.webpackChunkdocs||[]).push([[47925],{3905:function(e,t,r){r.d(t,{Zo:function(){return c},kt:function(){return h}});var n=r(67294);function o(e,t,r){return t in e?Object.defineProperty(e,t,{value:r,enumerable:!0,configurable:!0,writable:!0}):e[t]=r,e}function i(e,t){var r=Object.keys(e);if(Object.getOwnPropertySymbols){var n=Object.getOwnPropertySymbols(e);t&&(n=n.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),r.push.apply(r,n)}return r}function p(e){for(var t=1;t<arguments.length;t++){var r=null!=arguments[t]?arguments[t]:{};t%2?i(Object(r),!0).forEach((function(t){o(e,t,r[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(r)):i(Object(r)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(r,t))}))}return e}function a(e,t){if(null==e)return{};var r,n,o=function(e,t){if(null==e)return{};var r,n,o={},i=Object.keys(e);for(n=0;n<i.length;n++)r=i[n],t.indexOf(r)>=0||(o[r]=e[r]);return o}(e,t);if(Object.getOwnPropertySymbols){var i=Object.getOwnPropertySymbols(e);for(n=0;n<i.length;n++)r=i[n],t.indexOf(r)>=0||Object.prototype.propertyIsEnumerable.call(e,r)&&(o[r]=e[r])}return o}var l=n.createContext({}),s=function(e){var t=n.useContext(l),r=t;return e&&(r="function"==typeof e?e(t):p(p({},t),e)),r},c=function(e){var t=s(e.components);return n.createElement(l.Provider,{value:t},e.children)},u={inlineCode:"code",wrapper:function(e){var t=e.children;return n.createElement(n.Fragment,{},t)}},d=n.forwardRef((function(e,t){var r=e.components,o=e.mdxType,i=e.originalType,l=e.parentName,c=a(e,["components","mdxType","originalType","parentName"]),d=s(r),h=o,m=d["".concat(l,".").concat(h)]||d[h]||u[h]||i;return r?n.createElement(m,p(p({ref:t},c),{},{components:r})):n.createElement(m,p({ref:t},c))}));function h(e,t){var r=arguments,o=t&&t.mdxType;if("string"==typeof e||o){var i=r.length,p=new Array(i);p[0]=d;var a={};for(var l in t)hasOwnProperty.call(t,l)&&(a[l]=t[l]);a.originalType=e,a.mdxType="string"==typeof e?e:o,p[1]=a;for(var s=2;s<i;s++)p[s]=r[s];return n.createElement.apply(null,p)}return n.createElement.apply(null,r)}d.displayName="MDXCreateElement"},70594:function(e,t,r){r.r(t),r.d(t,{frontMatter:function(){return a},contentTitle:function(){return l},metadata:function(){return s},toc:function(){return c},default:function(){return d}});var n=r(87462),o=r(63366),i=(r(67294),r(3905)),p=["components"],a={title:"Struct BlockOptions",sidebar_label:"BlockOptions",description:"Represents block particle options"},l="Struct BlockOptions",s={unversionedId:"api/CopperSharp.Contexts/BlockOptions",id:"api/CopperSharp.Contexts/BlockOptions",title:"Struct BlockOptions",description:"Represents block particle options",source:"@site/docs/api/CopperSharp.Contexts/BlockOptions.md",sourceDirName:"api/CopperSharp.Contexts",slug:"/api/CopperSharp.Contexts/BlockOptions",permalink:"/docs/api/CopperSharp.Contexts/BlockOptions",editUrl:"https://github.com/Maxuss/CopperSharp/docs/api/CopperSharp.Contexts/BlockOptions.md",tags:[],version:"current",frontMatter:{title:"Struct BlockOptions",sidebar_label:"BlockOptions",description:"Represents block particle options"},sidebar:"tutorialSidebar",previous:{title:"Index",permalink:"/docs/api/CopperSharp.Contexts/"},next:{title:"DataStorage",permalink:"/docs/api/CopperSharp.Contexts/DataStorage"}},c=[{value:"<strong>Assembly</strong>: CopperSharp.dll",id:"assembly-coppersharpdll",children:[],level:6},{value:"View Source",id:"view-source",children:[],level:6},{value:"Properties",id:"properties",children:[{value:"State",id:"state",children:[{value:"View Source",id:"view-source-1",children:[],level:6}],level:3}],level:2},{value:"Methods",id:"methods",children:[{value:"ToString()",id:"tostring",children:[{value:"View Source",id:"view-source-2",children:[],level:6},{value:"Returns",id:"returns",children:[],level:5}],level:3}],level:2},{value:"Implements",id:"implements",children:[],level:2}],u={toc:c};function d(e){var t=e.components,r=(0,o.Z)(e,p);return(0,i.kt)("wrapper",(0,n.Z)({},u,r,{components:t,mdxType:"MDXLayout"}),(0,i.kt)("h1",{id:"struct-blockoptions"},"Struct BlockOptions"),(0,i.kt)("p",null,"Represents block particle options"),(0,i.kt)("h6",{id:"assembly-coppersharpdll"},(0,i.kt)("strong",{parentName:"h6"},"Assembly"),": CopperSharp.dll"),(0,i.kt)("h6",{id:"view-source"},(0,i.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Contexts/WorldPlayer.cs#L249"},"View Source")),(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public struct BlockOptions : IParticleOptions\n")),(0,i.kt)("h2",{id:"properties"},"Properties"),(0,i.kt)("h3",{id:"state"},"State"),(0,i.kt)("p",null,"Material of the block"),(0,i.kt)("h6",{id:"view-source-1"},(0,i.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Contexts/WorldPlayer.cs#L254"},"View Source")),(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public Material State { get; }\n")),(0,i.kt)("h2",{id:"methods"},"Methods"),(0,i.kt)("h3",{id:"tostring"},"ToString()"),(0,i.kt)("p",null,"Returns string representation of this particle options"),(0,i.kt)("h6",{id:"view-source-2"},(0,i.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Contexts/WorldPlayer.cs#L266"},"View Source")),(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public override string ToString()\n")),(0,i.kt)("h5",{id:"returns"},"Returns"),(0,i.kt)("p",null,(0,i.kt)("inlineCode",{parentName:"p"},"System.String")),(0,i.kt)("h2",{id:"implements"},"Implements"),(0,i.kt)("ul",null,(0,i.kt)("li",{parentName:"ul"},(0,i.kt)("a",{parentName:"li",href:"../CopperSharp.Contexts/IParticleOptions"},"CopperSharp.Contexts.IParticleOptions"))))}d.isMDXComponent=!0}}]);