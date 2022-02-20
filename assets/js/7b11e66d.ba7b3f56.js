"use strict";(self.webpackChunkdocs=self.webpackChunkdocs||[]).push([[37574],{3905:function(e,t,r){r.d(t,{Zo:function(){return c},kt:function(){return u}});var n=r(67294);function a(e,t,r){return t in e?Object.defineProperty(e,t,{value:r,enumerable:!0,configurable:!0,writable:!0}):e[t]=r,e}function o(e,t){var r=Object.keys(e);if(Object.getOwnPropertySymbols){var n=Object.getOwnPropertySymbols(e);t&&(n=n.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),r.push.apply(r,n)}return r}function s(e){for(var t=1;t<arguments.length;t++){var r=null!=arguments[t]?arguments[t]:{};t%2?o(Object(r),!0).forEach((function(t){a(e,t,r[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(r)):o(Object(r)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(r,t))}))}return e}function i(e,t){if(null==e)return{};var r,n,a=function(e,t){if(null==e)return{};var r,n,a={},o=Object.keys(e);for(n=0;n<o.length;n++)r=o[n],t.indexOf(r)>=0||(a[r]=e[r]);return a}(e,t);if(Object.getOwnPropertySymbols){var o=Object.getOwnPropertySymbols(e);for(n=0;n<o.length;n++)r=o[n],t.indexOf(r)>=0||Object.prototype.propertyIsEnumerable.call(e,r)&&(a[r]=e[r])}return a}var p=n.createContext({}),l=function(e){var t=n.useContext(p),r=t;return e&&(r="function"==typeof e?e(t):s(s({},t),e)),r},c=function(e){var t=l(e.components);return n.createElement(p.Provider,{value:t},e.children)},m={inlineCode:"code",wrapper:function(e){var t=e.children;return n.createElement(n.Fragment,{},t)}},d=n.forwardRef((function(e,t){var r=e.components,a=e.mdxType,o=e.originalType,p=e.parentName,c=i(e,["components","mdxType","originalType","parentName"]),d=l(r),u=a,h=d["".concat(p,".").concat(u)]||d[u]||m[u]||o;return r?n.createElement(h,s(s({ref:t},c),{},{components:r})):n.createElement(h,s({ref:t},c))}));function u(e,t){var r=arguments,a=t&&t.mdxType;if("string"==typeof e||a){var o=r.length,s=new Array(o);s[0]=d;var i={};for(var p in t)hasOwnProperty.call(t,p)&&(i[p]=t[p]);i.originalType=e,i.mdxType="string"==typeof e?e:a,s[1]=i;for(var l=2;l<o;l++)s[l]=r[l];return n.createElement.apply(null,s)}return n.createElement.apply(null,r)}d.displayName="MDXCreateElement"},62255:function(e,t,r){r.r(t),r.d(t,{frontMatter:function(){return i},contentTitle:function(){return p},metadata:function(){return l},toc:function(){return c},default:function(){return d}});var n=r(87462),a=r(63366),o=(r(67294),r(3905)),s=["components"],i={title:"Class UsedTotem",sidebar_label:"UsedTotem",description:"Triggers when the player uses a totem."},p="Class UsedTotem",l={unversionedId:"api/CopperSharp.Advancements.Triggers/UsedTotem",id:"api/CopperSharp.Advancements.Triggers/UsedTotem",title:"Class UsedTotem",description:"Triggers when the player uses a totem.",source:"@site/docs/api/CopperSharp.Advancements.Triggers/UsedTotem.md",sourceDirName:"api/CopperSharp.Advancements.Triggers",slug:"/api/CopperSharp.Advancements.Triggers/UsedTotem",permalink:"/docs/api/CopperSharp.Advancements.Triggers/UsedTotem",editUrl:"https://github.com/Maxuss/CopperSharp/docs/api/CopperSharp.Advancements.Triggers/UsedTotem.md",tags:[],version:"current",frontMatter:{title:"Class UsedTotem",sidebar_label:"UsedTotem",description:"Triggers when the player uses a totem."},sidebar:"tutorialSidebar",previous:{title:"UsedEnderEye",permalink:"/docs/api/CopperSharp.Advancements.Triggers/UsedEnderEye"},next:{title:"UsingItem",permalink:"/docs/api/CopperSharp.Advancements.Triggers/UsingItem"}},c=[{value:"<strong>Assembly</strong>: CopperSharp.dll",id:"assembly-coppersharpdll",children:[],level:6},{value:"View Source",id:"view-source",children:[],level:6},{value:"Methods",id:"methods",children:[{value:"Totem(ItemPredicate)",id:"totemitempredicate",children:[{value:"View Source",id:"view-source-1",children:[],level:6},{value:"Returns",id:"returns",children:[],level:5},{value:"Parameters",id:"parameters",children:[],level:5}],level:3}],level:2}],m={toc:c};function d(e){var t=e.components,r=(0,a.Z)(e,s);return(0,o.kt)("wrapper",(0,n.Z)({},m,r,{components:t,mdxType:"MDXLayout"}),(0,o.kt)("h1",{id:"class-usedtotem"},"Class UsedTotem"),(0,o.kt)("p",null,"Triggers when the player uses a totem."),(0,o.kt)("h6",{id:"assembly-coppersharpdll"},(0,o.kt)("strong",{parentName:"h6"},"Assembly"),": CopperSharp.dll"),(0,o.kt)("h6",{id:"view-source"},(0,o.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Advancements/Triggers/UsedTotem.cs#L8"},"View Source")),(0,o.kt)("pre",null,(0,o.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public sealed class UsedTotem : TriggerCondition\n")),(0,o.kt)("h2",{id:"methods"},"Methods"),(0,o.kt)("h3",{id:"totemitempredicate"},"Totem(ItemPredicate)"),(0,o.kt)("p",null,"Sets the totem item used"),(0,o.kt)("h6",{id:"view-source-1"},(0,o.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Advancements/Triggers/UsedTotem.cs#L16"},"View Source")),(0,o.kt)("pre",null,(0,o.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public UsedTotem Totem(ItemPredicate totem)\n")),(0,o.kt)("h5",{id:"returns"},"Returns"),(0,o.kt)("p",null,(0,o.kt)("a",{parentName:"p",href:"../CopperSharp.Advancements.Triggers/UsedTotem"},"CopperSharp.Advancements.Triggers.UsedTotem"),": This trigger"),(0,o.kt)("h5",{id:"parameters"},"Parameters"),(0,o.kt)("table",null,(0,o.kt)("thead",{parentName:"table"},(0,o.kt)("tr",{parentName:"thead"},(0,o.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,o.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,o.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,o.kt)("tbody",{parentName:"table"},(0,o.kt)("tr",{parentName:"tbody"},(0,o.kt)("td",{parentName:"tr",align:"left"},(0,o.kt)("a",{parentName:"td",href:"../CopperSharp.Advancements.Predicates/ItemPredicate"},"CopperSharp.Advancements.Predicates.ItemPredicate")),(0,o.kt)("td",{parentName:"tr",align:"left"},(0,o.kt)("em",{parentName:"td"},"totem")),(0,o.kt)("td",{parentName:"tr",align:"left"},"Item to be set")))))}d.isMDXComponent=!0}}]);