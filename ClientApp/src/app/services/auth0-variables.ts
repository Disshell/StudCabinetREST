interface AuthConfig {
  clientID: string;
  domain: string;
  callbackURL: string;
}

export const AUTH_CONFIG: AuthConfig = {
  clientID: 'sfV1H9S6hzYYGRS48ld5Qd0f6GnSlBzu',
  domain: 'disshell.eu.auth0.com',
  callbackURL: 'http://localhost:5000'
};
