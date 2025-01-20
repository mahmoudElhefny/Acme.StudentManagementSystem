import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

// function configureRoutes(routesService: RoutesService) {
//   return () => {
//     routesService.add([
//       {
//         path: '/',
//         name: '::Menu:Home',
//         iconClass: 'fas fa-home',
//         order: 1,
//         layout: eLayoutType.application,
//       },
//     ]);
//   };
// }
function configureRoutes(routes: RoutesService) {
  return () => {
    routes.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/student-hup',
        name: '::Menu:StudentHup',
        iconClass: 'fas fa-student',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/students',
        name: '::Menu:students',
        parentName: '::Menu:StudentHup',
        layout: eLayoutType.application,
      },
    ]);
  };
}

