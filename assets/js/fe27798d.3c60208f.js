"use strict";(self.webpackChunkdocs=self.webpackChunkdocs||[]).push([[79707],{3905:function(e,r,o){o.d(r,{Zo:function(){return c},kt:function(){return u}});var t=o(67294);function n(e,r,o){return r in e?Object.defineProperty(e,r,{value:o,enumerable:!0,configurable:!0,writable:!0}):e[r]=o,e}function a(e,r){var o=Object.keys(e);if(Object.getOwnPropertySymbols){var t=Object.getOwnPropertySymbols(e);r&&(t=t.filter((function(r){return Object.getOwnPropertyDescriptor(e,r).enumerable}))),o.push.apply(o,t)}return o}function p(e){for(var r=1;r<arguments.length;r++){var o=null!=arguments[r]?arguments[r]:{};r%2?a(Object(o),!0).forEach((function(r){n(e,r,o[r])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(o)):a(Object(o)).forEach((function(r){Object.defineProperty(e,r,Object.getOwnPropertyDescriptor(o,r))}))}return e}function i(e,r){if(null==e)return{};var o,t,n=function(e,r){if(null==e)return{};var o,t,n={},a=Object.keys(e);for(t=0;t<a.length;t++)o=a[t],r.indexOf(o)>=0||(n[o]=e[o]);return n}(e,r);if(Object.getOwnPropertySymbols){var a=Object.getOwnPropertySymbols(e);for(t=0;t<a.length;t++)o=a[t],r.indexOf(o)>=0||Object.prototype.propertyIsEnumerable.call(e,o)&&(n[o]=e[o])}return n}var l=t.createContext({}),s=function(e){var r=t.useContext(l),o=r;return e&&(o="function"==typeof e?e(r):p(p({},r),e)),o},c=function(e){var r=s(e.components);return t.createElement(l.Provider,{value:r},e.children)},h={inlineCode:"code",wrapper:function(e){var r=e.children;return t.createElement(t.Fragment,{},r)}},k=t.forwardRef((function(e,r){var o=e.components,n=e.mdxType,a=e.originalType,l=e.parentName,c=i(e,["components","mdxType","originalType","parentName"]),k=s(o),u=n,d=k["".concat(l,".").concat(u)]||k[u]||h[u]||a;return o?t.createElement(d,p(p({ref:r},c),{},{components:o})):t.createElement(d,p({ref:r},c))}));function u(e,r){var o=arguments,n=r&&r.mdxType;if("string"==typeof e||n){var a=o.length,p=new Array(a);p[0]=k;var i={};for(var l in r)hasOwnProperty.call(r,l)&&(i[l]=r[l]);i.originalType=e,i.mdxType="string"==typeof e?e:n,p[1]=i;for(var s=2;s<a;s++)p[s]=o[s];return t.createElement.apply(null,p)}return t.createElement.apply(null,o)}k.displayName="MDXCreateElement"},48391:function(e,r,o){o.r(r),o.d(r,{frontMatter:function(){return i},contentTitle:function(){return l},metadata:function(){return s},toc:function(){return c},default:function(){return k}});var t=o(87462),n=o(63366),a=(o(67294),o(3905)),p=["components"],i={title:"Namespace CopperSharp.Hooks",sidebar_label:"Index",sidebar_position:0},l="Namespace CopperSharp.Hooks",s={unversionedId:"api/CopperSharp.Hooks/CopperSharp.Hooks",id:"api/CopperSharp.Hooks/CopperSharp.Hooks",title:"Namespace CopperSharp.Hooks",description:"Classes",source:"@site/docs/api/CopperSharp.Hooks/CopperSharp.Hooks.md",sourceDirName:"api/CopperSharp.Hooks",slug:"/api/CopperSharp.Hooks/",permalink:"/docs/api/CopperSharp.Hooks/",editUrl:"https://github.com/Maxuss/CopperSharp/docs/api/CopperSharp.Hooks/CopperSharp.Hooks.md",tags:[],version:"current",sidebarPosition:0,frontMatter:{title:"Namespace CopperSharp.Hooks",sidebar_label:"Index",sidebar_position:0},sidebar:"tutorialSidebar",previous:{title:"MinecraftDelegate",permalink:"/docs/api/CopperSharp.Functions/MinecraftDelegate"},next:{title:"AbstractHook",permalink:"/docs/api/CopperSharp.Hooks/AbstractHook"}},c=[{value:"Classes",id:"classes",children:[{value:"AbstractHook",id:"abstracthook",children:[],level:3},{value:"HookAttribute",id:"hookattribute",children:[],level:3},{value:"HookContext",id:"hookcontext",children:[],level:3},{value:"HookHandler",id:"hookhandler",children:[],level:3},{value:"RightClickHook",id:"rightclickhook",children:[],level:3}],level:2},{value:"Interfaces",id:"interfaces",children:[{value:"IHookHandler",id:"ihookhandler",children:[],level:3}],level:2}],h={toc:c};function k(e){var r=e.components,o=(0,n.Z)(e,p);return(0,a.kt)("wrapper",(0,t.Z)({},h,o,{components:r,mdxType:"MDXLayout"}),(0,a.kt)("h1",{id:"namespace-coppersharphooks"},"Namespace CopperSharp.Hooks"),(0,a.kt)("h2",{id:"classes"},"Classes"),(0,a.kt)("h3",{id:"abstracthook"},(0,a.kt)("a",{parentName:"h3",href:"../CopperSharp.Hooks/AbstractHook"},"AbstractHook")),(0,a.kt)("p",null,"A global abstract class for hooks"),(0,a.kt)("h3",{id:"hookattribute"},(0,a.kt)("a",{parentName:"h3",href:"../CopperSharp.Hooks/HookAttribute"},"HookAttribute")),(0,a.kt)("p",null,"Represents a hook that is invoked each time some kind of event is called"),(0,a.kt)("h3",{id:"hookcontext"},(0,a.kt)("a",{parentName:"h3",href:"../CopperSharp.Hooks/HookContext"},"HookContext")),(0,a.kt)("p",null,"An abstract super class for hook context scopes"),(0,a.kt)("h3",{id:"hookhandler"},(0,a.kt)("a",{parentName:"h3",href:"../CopperSharp.Hooks/HookHandler"},"HookHandler")),(0,a.kt)("p",null,"Represents a global hook handler"),(0,a.kt)("h3",{id:"rightclickhook"},(0,a.kt)("a",{parentName:"h3",href:"../CopperSharp.Hooks/RightClickHook"},"RightClickHook")),(0,a.kt)("p",null,"A hook that is ran each right click"),(0,a.kt)("h2",{id:"interfaces"},"Interfaces"),(0,a.kt)("h3",{id:"ihookhandler"},(0,a.kt)("a",{parentName:"h3",href:"../CopperSharp.Hooks/IHookHandler"},"IHookHandler")),(0,a.kt)("p",null,"A simple interface for distinguishing between hook handlers"))}k.isMDXComponent=!0}}]);