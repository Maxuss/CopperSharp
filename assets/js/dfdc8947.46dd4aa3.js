"use strict";(self.webpackChunkdocs=self.webpackChunkdocs||[]).push([[44418],{3905:function(e,t,n){n.d(t,{Zo:function(){return u},kt:function(){return m}});var r=n(67294);function a(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}function i(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,r)}return n}function o(e){for(var t=1;t<arguments.length;t++){var n=null!=arguments[t]?arguments[t]:{};t%2?i(Object(n),!0).forEach((function(t){a(e,t,n[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(n)):i(Object(n)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(n,t))}))}return e}function l(e,t){if(null==e)return{};var n,r,a=function(e,t){if(null==e)return{};var n,r,a={},i=Object.keys(e);for(r=0;r<i.length;r++)n=i[r],t.indexOf(n)>=0||(a[n]=e[n]);return a}(e,t);if(Object.getOwnPropertySymbols){var i=Object.getOwnPropertySymbols(e);for(r=0;r<i.length;r++)n=i[r],t.indexOf(n)>=0||Object.prototype.propertyIsEnumerable.call(e,n)&&(a[n]=e[n])}return a}var p=r.createContext({}),c=function(e){var t=r.useContext(p),n=t;return e&&(n="function"==typeof e?e(t):o(o({},t),e)),n},u=function(e){var t=c(e.components);return r.createElement(p.Provider,{value:t},e.children)},s={inlineCode:"code",wrapper:function(e){var t=e.children;return r.createElement(r.Fragment,{},t)}},d=r.forwardRef((function(e,t){var n=e.components,a=e.mdxType,i=e.originalType,p=e.parentName,u=l(e,["components","mdxType","originalType","parentName"]),d=c(n),m=a,h=d["".concat(p,".").concat(m)]||d[m]||s[m]||i;return n?r.createElement(h,o(o({ref:t},u),{},{components:n})):r.createElement(h,o({ref:t},u))}));function m(e,t){var n=arguments,a=t&&t.mdxType;if("string"==typeof e||a){var i=n.length,o=new Array(i);o[0]=d;var l={};for(var p in t)hasOwnProperty.call(t,p)&&(l[p]=t[p]);l.originalType=e,l.mdxType="string"==typeof e?e:a,o[1]=l;for(var c=2;c<i;c++)o[c]=n[c];return r.createElement.apply(null,o)}return r.createElement.apply(null,n)}d.displayName="MDXCreateElement"},26933:function(e,t,n){n.r(t),n.d(t,{frontMatter:function(){return l},contentTitle:function(){return p},metadata:function(){return c},toc:function(){return u},default:function(){return d}});var r=n(87462),a=n(63366),i=(n(67294),n(3905)),o=["components"],l={title:"Class FunctionManager",sidebar_label:"FunctionManager",description:"A global function manager"},p="Class FunctionManager",c={unversionedId:"api/CopperSharp.Functions/FunctionManager",id:"api/CopperSharp.Functions/FunctionManager",title:"Class FunctionManager",description:"A global function manager",source:"@site/docs/api/CopperSharp.Functions/FunctionManager.md",sourceDirName:"api/CopperSharp.Functions",slug:"/api/CopperSharp.Functions/FunctionManager",permalink:"/docs/api/CopperSharp.Functions/FunctionManager",editUrl:"https://github.com/Maxuss/CopperSharp/docs/api/CopperSharp.Functions/FunctionManager.md",tags:[],version:"current",frontMatter:{title:"Class FunctionManager",sidebar_label:"FunctionManager",description:"A global function manager"},sidebar:"tutorialSidebar",previous:{title:"FunctionHandlerAttribute",permalink:"/docs/api/CopperSharp.Functions/FunctionHandlerAttribute"},next:{title:"IFunction",permalink:"/docs/api/CopperSharp.Functions/IFunction"}},u=[{value:"<strong>Assembly</strong>: CopperSharp.dll",id:"assembly-coppersharpdll",children:[],level:6},{value:"View Source",id:"view-source",children:[],level:6},{value:"Methods",id:"methods",children:[{value:"Lookup(IFunction)",id:"lookupifunction",children:[{value:"View Source",id:"view-source-1",children:[],level:6},{value:"Returns",id:"returns",children:[],level:5},{value:"Parameters",id:"parameters",children:[],level:5}],level:3},{value:"LookupAsyncs(IFunction)",id:"lookupasyncsifunction",children:[{value:"View Source",id:"view-source-2",children:[],level:6},{value:"Returns",id:"returns-1",children:[],level:5},{value:"Parameters",id:"parameters-1",children:[],level:5}],level:3},{value:"Register(IFunction)",id:"registerifunction",children:[{value:"View Source",id:"view-source-3",children:[],level:6},{value:"Parameters",id:"parameters-2",children:[],level:5}],level:3}],level:2}],s={toc:u};function d(e){var t=e.components,n=(0,a.Z)(e,o);return(0,i.kt)("wrapper",(0,r.Z)({},s,n,{components:t,mdxType:"MDXLayout"}),(0,i.kt)("h1",{id:"class-functionmanager"},"Class FunctionManager"),(0,i.kt)("p",null,"A global function manager"),(0,i.kt)("h6",{id:"assembly-coppersharpdll"},(0,i.kt)("strong",{parentName:"h6"},"Assembly"),": CopperSharp.dll"),(0,i.kt)("h6",{id:"view-source"},(0,i.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Functions/FunctionManager.cs#L9"},"View Source")),(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public static class FunctionManager : object\n")),(0,i.kt)("h2",{id:"methods"},"Methods"),(0,i.kt)("h3",{id:"lookupifunction"},"Lookup(IFunction)"),(0,i.kt)("p",null,"Looks up provided function and gets all methods"),(0,i.kt)("h6",{id:"view-source-1"},(0,i.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Functions/FunctionManager.cs#L25"},"View Source")),(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public static List<(MinecraftDelegate, FunctionHandlerAttribute)>? Lookup(IFunction fn)\n")),(0,i.kt)("h5",{id:"returns"},"Returns"),(0,i.kt)("p",null,(0,i.kt)("inlineCode",{parentName:"p"},"System.Nullable<List<System.ValueTuple<CopperSharp.Functions.MinecraftDelegate,CopperSharp.Functions.FunctionHandlerAttribute>>>"),": Null if function not registered, otherwise list of methods that can be called"),(0,i.kt)("h5",{id:"parameters"},"Parameters"),(0,i.kt)("table",null,(0,i.kt)("thead",{parentName:"table"},(0,i.kt)("tr",{parentName:"thead"},(0,i.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,i.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,i.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,i.kt)("tbody",{parentName:"table"},(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("a",{parentName:"td",href:"../CopperSharp.Functions/IFunction"},"CopperSharp.Functions.IFunction")),(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("em",{parentName:"td"},"fn")),(0,i.kt)("td",{parentName:"tr",align:"left"},"Function to be looked up")))),(0,i.kt)("h3",{id:"lookupasyncsifunction"},"LookupAsyncs(IFunction)"),(0,i.kt)("p",null,"Looks up provided function and gets all async methods"),(0,i.kt)("h6",{id:"view-source-2"},(0,i.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Functions/FunctionManager.cs#L39"},"View Source")),(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public static List<(AsyncMinecraftDelegate, FunctionHandlerAttribute)>? LookupAsyncs(IFunction fn)\n")),(0,i.kt)("h5",{id:"returns-1"},"Returns"),(0,i.kt)("p",null,(0,i.kt)("inlineCode",{parentName:"p"},"System.Nullable<List<System.ValueTuple<CopperSharp.Functions.AsyncMinecraftDelegate,CopperSharp.Functions.FunctionHandlerAttribute>>>"),": Null if function not registered, otherwise list of methods that can be called"),(0,i.kt)("h5",{id:"parameters-1"},"Parameters"),(0,i.kt)("table",null,(0,i.kt)("thead",{parentName:"table"},(0,i.kt)("tr",{parentName:"thead"},(0,i.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,i.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,i.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,i.kt)("tbody",{parentName:"table"},(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("a",{parentName:"td",href:"../CopperSharp.Functions/IFunction"},"CopperSharp.Functions.IFunction")),(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("em",{parentName:"td"},"fn")),(0,i.kt)("td",{parentName:"tr",align:"left"},"Function to be looked up")))),(0,i.kt)("h3",{id:"registerifunction"},"Register(IFunction)"),(0,i.kt)("p",null,"Registers provided function as well as all it","'","s handlers"),(0,i.kt)("h6",{id:"view-source-3"},(0,i.kt)("a",{parentName:"h6",href:"https://github.com/Maxuss/CopperSharp/blob/master/CopperSharp/Functions/FunctionManager.cs#L52"},"View Source")),(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-csharp",metastring:'title="Declaration"',title:'"Declaration"'},"public static void Register(IFunction fn)\n")),(0,i.kt)("h5",{id:"parameters-2"},"Parameters"),(0,i.kt)("table",null,(0,i.kt)("thead",{parentName:"table"},(0,i.kt)("tr",{parentName:"thead"},(0,i.kt)("th",{parentName:"tr",align:"left"},"Type"),(0,i.kt)("th",{parentName:"tr",align:"left"},"Name"),(0,i.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,i.kt)("tbody",{parentName:"table"},(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("a",{parentName:"td",href:"../CopperSharp.Functions/IFunction"},"CopperSharp.Functions.IFunction")),(0,i.kt)("td",{parentName:"tr",align:"left"},(0,i.kt)("em",{parentName:"td"},"fn")),(0,i.kt)("td",{parentName:"tr",align:"left"},"Function to be registered")))))}d.isMDXComponent=!0}}]);