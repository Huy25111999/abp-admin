import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'admin',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44377/',
    redirectUri: baseUrl,
    clientId: 'admin_App',
    responseType: 'code',
    scope: 'offline_access admin',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44377',
      rootNamespace: 'admin',
    },
  },
} as Environment;
