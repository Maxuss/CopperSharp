import React from 'react';
import clsx from 'clsx';
import styles from './HomepageFeatures.module.css';

type FeatureItem = {
  title: string;
  description: JSX.Element;
};

const FeatureList: FeatureItem[] = [
  {
    title: 'Well documented',
    description: (
      <>
          CopperSharp is well documented. You can view all the documentation
          on this website! Just go to <a href="/docs/api">API Documentation</a>!
      </>
    ),
  },
  {
    title: 'Functional API',
    description: (
      <>
          CopperSharp provides a high-level functional wrapping API for your
          datapacks. View examples <a href="/docs/examples">here</a>.
      </>
    ),
  },
  {
    title: 'Fast',
    description: (
      <>
          CopperSharp is asynchronous, which makes it very fast.
      </>
    ),
  },
];

function Feature({title, description}: FeatureItem) {
  return (
    <div className={clsx('col col--4')}>
      <div className="text--center padding-horiz--md">
        <h3>{title}</h3>
        <p>{description}</p>
      </div>
    </div>
  );
}

export default function HomepageFeatures(): JSX.Element {
  return (
    <section className={styles.features}>
      <div className="container">
        <div className="row">
          {FeatureList.map((props, idx) => (
            <Feature key={idx} {...props} />
          ))}
        </div>
      </div>
    </section>
  );
}
