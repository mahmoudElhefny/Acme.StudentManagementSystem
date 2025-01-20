import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'StudentManagementSystem',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44313/',
    redirectUri: baseUrl,
    clientId: 'StudentManagementSystem_App',
    responseType: 'code',
    scope: 'offline_access StudentManagementSystem',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44313',
      rootNamespace: 'Acme.StudentManagementSystem',
    },
  },
} as Environment;
