"use strict";(self.webpackChunkdocs=self.webpackChunkdocs||[]).push([[30882],{3905:function(e,t,r){r.d(t,{Zo:function(){return s},kt:function(){return d}});var n=r(67294);function a(e,t,r){return t in e?Object.defineProperty(e,t,{value:r,enumerable:!0,configurable:!0,writable:!0}):e[t]=r,e}function o(e,t){var r=Object.keys(e);if(Object.getOwnPropertySymbols){var n=Object.getOwnPropertySymbols(e);t&&(n=n.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),r.push.apply(r,n)}return r}function i(e){for(var t=1;t<arguments.length;t++){var r=null!=arguments[t]?arguments[t]:{};t%2?o(Object(r),!0).forEach((function(t){a(e,t,r[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(r)):o(Object(r)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(r,t))}))}return e}function c(e,t){if(null==e)return{};var r,n,a=function(e,t){if(null==e)return{};var r,n,a={},o=Object.keys(e);for(n=0;n<o.length;n++)r=o[n],t.indexOf(r)>=0||(a[r]=e[r]);return a}(e,t);if(Object.getOwnPropertySymbols){var o=Object.getOwnPropertySymbols(e);for(n=0;n<o.length;n++)r=o[n],t.indexOf(r)>=0||Object.prototype.propertyIsEnumerable.call(e,r)&&(a[r]=e[r])}return a}var p=n.createContext({}),l=function(e){var t=n.useContext(p),r=t;return e&&(r="function"==typeof e?e(t):i(i({},t),e)),r},s=function(e){var t=l(e.components);return n.createElement(p.Provider,{value:t},e.children)},u={inlineCode:"code",wrapper:function(e){var t=e.children;return n.createElement(n.Fragment,{},t)}},h=n.forwardRef((function(e,t){var r=e.components,a=e.mdxType,o=e.originalType,p=e.parentName,s=c(e,["components","mdxType","originalType","parentName"]),h=l(r),d=a,f=h["".concat(p,".").concat(d)]||h[d]||u[d]||o;return r?n.createElement(f,i(i({ref:t},s),{},{components:r})):n.createElement(f,i({ref:t},s))}));function d(e,t){var r=arguments,a=t&&t.mdxType;if("string"==typeof e||a){var o=r.length,i=new Array(o);i[0]=h;var c={};for(var p in t)hasOwnProperty.call(t,p)&&(c[p]=t[p]);c.originalType=e,c.mdxType="string"==typeof e?e:a,i[1]=c;for(var l=2;l<o;l++)i[l]=r[l];return n.createElement.apply(null,i)}return n.createElement.apply(null,r)}h.displayName="MDXCreateElement"},91988:function(e,t,r){r.r(t),r.d(t,{frontMatter:function(){return c},contentTitle:function(){return p},metadata:function(){return l},toc:function(){return s},default:function(){return h}});var n=r(87462),a=r(63366),o=(r(67294),r(3905)),i=["components"],c={title:"Struct Vec2",sidebar_label:"Vec2",description:"Represents a rotation vector"},p="Struct Vec2",l={unversionedId:"api/CopperSharp.Utils/Vec2",id:"api/CopperSharp.Utils/Vec2",title:"Struct Vec2",description:"Represents a rotation vector",source:"@site/docs/api/CopperSharp.Utils/Vec2.md",sourceDirName:"api/CopperSharp.Utils",slug:"/api/CopperSharp.Utils/Vec2",permalink:"/docs/api/CopperSharp.Utils/Vec2",editUrl:"https://github.com/Maxuss/CopperSharp/docs/api/CopperSharp.Utils/Vec2.md",tags:[],version:"current",frontMatter:{title:"Struct Vec2",sidebar_label:"Vec2",description:"Represents a rotation vector"},sidebar:"tutorialSidebar",previous:{title:"TypedVec2<TValue>",permalink:"/docs/api/CopperSharp.Utils/TypedVec2`TValue`"},next:{title:"Vec3",permalink:"/docs/api/CopperSharp.Utils/Vec3"}},s=[{value:"<strong>Assembly</strong>: CopperSharp.dll",id:"assembly-coppersharpdll",children:[],level:6},{value:"View Source",id:"view-source",children:[],level:6},{value:"Properties",id:"properties",children:[{value:"Yaw",id:"yaw",children:[{value:"View Source",id:"view-source-1",children:[],level:6}],level:3},{value:"Pitch",id:"pitch",children:[{value:"View Source",id:"view-source-2",children:[],level:6}],level:3}],level:2}],u={toc:s};function h(e){var t=e.components,r=(0,a.Z)(e,i);return(0,o.kt)("wrapper",(0,n.Z)({},u,r,{components:t,mdxType:"MDXLayout"}),(0,o.kt)("h1",{id:"struct-vec2"},"Struct Vec2"),(0,o.kt)("p",null,"Represents a rotation vector"),(0,o.kt)("h6",{id:"assembly-coppersharpdll"},(0,o.kt)("strong",{parentName:"h6"},"Assembly"),": CopperSharp.dll"),(0,o.kt)("h6",{id:"view-source"},(0,o.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Utils/Vec2.cs#L6"},"View Source")),(0,o.kt)("pre",null,(0,o.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public struct Vec2\n")),(0,o.kt)("h2",{id:"properties"},"Properties"),(0,o.kt)("h3",{id:"yaw"},"Yaw"),(0,o.kt)("p",null,"Yaw (rotation clockwise) of the vector"),(0,o.kt)("h6",{id:"view-source-1"},(0,o.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Utils/Vec2.cs#L22"},"View Source")),(0,o.kt)("pre",null,(0,o.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public float Yaw { get; }\n")),(0,o.kt)("h3",{id:"pitch"},"Pitch"),(0,o.kt)("p",null,"Pitch (declination from the horizon) of the vector"),(0,o.kt)("h6",{id:"view-source-2"},(0,o.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Utils/Vec2.cs#L27"},"View Source")),(0,o.kt)("pre",null,(0,o.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public float Pitch { get; }\n")))}h.isMDXComponent=!0}}]);