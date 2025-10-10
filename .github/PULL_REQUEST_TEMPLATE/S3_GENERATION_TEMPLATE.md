## Description
<!--- Describe your changes in detail -->

### (For Reviewers) How To Review S3 Generation PRs:
When reviewing S3 generation PRs, avoid using GitHub’s diff view — instead, compare files side by side.

1. Open the custom code file in GitHub.
2. For the generated code, click the three dots → “View file”.
3. View the custom code on the left and the generated code on the right.

Focus on identifying behavioral differences, such as:
1. Missing custom logic in getters/setters
2. Changes in marshalling or unmarshalling behavior

Note that some custom logic may have been moved into methods like PostMarshallCustomization() (for marshallers) or partial methods (for unmarshallers). Be sure to review those as well.

Some custom logic from the original code may have been moved into dedicated methods.
For example:

* Marshallers may use a custom method like PostMarshallCustomization().
* Unmarshallers may include partial methods to preserve custom behavior.
Be sure to review these methods when comparing generated and custom code.
[This example](https://github.com/aws/aws-sdk-net/blob/main/sdk/src/Services/S3/Custom/Model/Internal/MarshallTransformations/ListObjectsV2ResponseUnmarshaller.cs#L32-L43) shows a custom method defined in the custom unmarshaller that is invoked by the generated unmarshaller.

## Motivation and Context
<!--- Why is this change required? What problem does it solve? -->
<!--- If it fixes an open [issue][issues], please link to the issue here -->

## Testing
<!--- Please describe in detail how you tested your changes -->
<!--- Include details of your testing environment, and the tests you ran to -->
<!--- see how your change affects other areas of the code, etc. -->


## Types of changes
<!--- What types of changes does your code introduce? Put an `x` in all the boxes that apply: -->
- [ ] S3 Generation (PR which generates S3, which can be a combination of custom and generated code)

## Checklist
<!--- Go over all the following points, and put an `x` in all the boxes that apply -->
<!--- If you're unsure about any of these, don't hesitate to ask. We're here to help! -->
- [ ] My code follows the code style of this project
- [ ] My change requires a change to the documentation
- [ ] I have updated the documentation accordingly
- [ ] I have read the **README** document
- [ ] I have added tests to cover my changes
- [ ] All new and existing tests passed
- [ ] I have run the fuzz tests for requests and responses and ensured there were no breaking changes

## License
<!--- The SDK is released under the [Apache 2.0 license][license], so any code you submit will be released under that license -->
<!--- For substantial contributions, we may ask you to sign a [Contributor License Agreement (CLA)][cla] -->
<!--- Put an `x` in the below box if you confirm that this request can be released under the Apache 2 license -->
- [ ] I confirm that this pull request can be released under the Apache 2 license

[issues]: https://github.com/aws/aws-sdk-net/issues
[license]: http://aws.amazon.com/apache2.0/
[cla]: http://en.wikipedia.org/wiki/Contributor_License_Agreement